using BDE.Composite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVC.LanguageManager;
using BDE.Language;
using SVC;

namespace DAL
{
    public static class DAL_Language
    {
        public static bool CreateLanguage(string languageName)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"insert into tb_Idiomas (nombreIdioma,[default]) values (@p_languageName,0)";
            cmd.Parameters.AddWithValue("@p_languageName", languageName);
            cmd.CommandType = CommandType.Text;
            return cmd.ExecuteNonQuery() > 0 ? true : false;
        }

        public static List<BE_Language> GetLanguages()
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"SELECT * FROM tb_Idiomas";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            var languages = new List<BE_Language>();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    languages.Add(new BE_Language
                    {
                        Name = dr["nombreIdioma"].ToString(),
                        IsDefault = Convert.ToBoolean(dr["default"].ToString()),
                        LanguageCode = dr["language_code"].ToString()

                    });
                }
                return languages;
            }
            return null;
        }

        public static Dictionary<string, string> GetTraductions(string formName, string language)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"sp_GetTraductions";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("language", language);
            cmd.Parameters.AddWithValue("formName", formName);
            cmd.ExecuteNonQuery();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                Dictionary<string, string> traductions = new Dictionary<string, string>();
                while (dr.Read())
                {
                    traductions.Add(dr["nombreControl"].ToString(), dr["traduccion"].ToString());
                }
                return traductions;
            }
            return null;
        }

        public static void LoadTraductions()
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"sp_GetTraductions";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            var dr = cmd.ExecuteReader();
            var languages = GetLanguages();
            languages.ForEach(l => Console.WriteLine($"{l.Name} {(l.IsDefault ? "true" : "false")}"));
            SessionManager.translations = new Dictionary<BE_Language, Dictionary<string, Dictionary<string, string>>>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string languageName = dr["nombreIdioma"].ToString(), formName = dr["nombreForm"].ToString(),
                        crtl = dr["nombreControl"].ToString(), translation = dr["traduccion"].ToString();

                    var language = languages.FirstOrDefault(x => x.Name.Equals(languageName, StringComparison.OrdinalIgnoreCase));

                    if (language == null)
                    {
                        throw new Exception("Error en encontrar idioma");
                    }

                    if (!SessionManager.translations.ContainsKey(language))
                    {
                        SessionManager.translations[language] = new Dictionary<string, Dictionary<string, string>>();
                    }

                    if (!SessionManager.translations[language].ContainsKey(formName))
                    {
                        SessionManager.translations[language][formName] = new Dictionary<string, string>();
                    }

                    SessionManager.translations[language][formName][crtl] = translation;
                }
            }
            LanguageManager.CurrentLanguage = languages.FirstOrDefault(l => l.IsDefault);
        }

        public static void SetDefaultLanguage(string languague)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"sp_SetLanguageDefault";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("language", languague);
            cmd.ExecuteNonQuery();
        }

        public static bool UpdateTranslations(Tuple<string, string, DataTable> translations)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            var entry = SessionManager.translations.FirstOrDefault(i => i.Key.Name == translations.Item1);
            BE_Language len = entry.Key;

            bool anyChanges = false;  // Variable para comprobar si hubo cambios

            foreach (DataRow row in translations.Item3.Rows)
            {
                if (row[1].ToString() != "")
                {
                    string controlName = row[0].ToString();
                    string translationValue = row[1].ToString();

                    // Primero verificamos si se necesita hacer una actualización
                    if (len != null && SessionManager.translations.ContainsKey(len) &&
                        SessionManager.translations[len].ContainsKey(translations.Item2) &&
                        SessionManager.translations[len][translations.Item2].ContainsKey(controlName) &&
                        SessionManager.translations[len][translations.Item2][controlName] != translationValue)
                    {
                        cmd.CommandText = @"UPDATE idioma_control SET traduccion=@p_translation
                        WHERE id_Idioma=(SELECT TOP 1 i.id_Idioma FROM tb_Idiomas i WHERE i.nombreIdioma=@p_language)
                        AND id_Control=(SELECT TOP 1 c.id_Control 
                            FROM tb_Controles c 
                            INNER JOIN tb_Forms f ON f.id_Form=c.id_Form
                            WHERE c.nombreControl=@p_controlName AND f.nombreForm=@p_formName);";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@p_translation", translationValue);
                        cmd.Parameters.AddWithValue("@p_language", translations.Item1);
                        cmd.Parameters.AddWithValue("@p_controlName", controlName);
                        cmd.Parameters.AddWithValue("@p_formName", translations.Item2);

                        cmd.ExecuteNonQuery();
                        anyChanges = true;
                    }
                    // Caso para insertar nuevas traducciones
                    else
                    {
                        cmd.CommandText = @"INSERT INTO idioma_control (id_Idioma, id_Control, traduccion)
                                SELECT 
                                    (SELECT TOP 1 i.id_Idioma 
                                     FROM tb_Idiomas i 
                                     WHERE i.nombreIdioma = @p_language),
                                    (SELECT TOP 1 c.id_Control 
                                     FROM tb_Controles c 
                                        INNER JOIN tb_Forms f ON f.id_Form = c.id_Form
                                     WHERE c.nombreControl = @p_controlName AND f.nombreForm = @p_formName),
                                    @p_translation;";

                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@p_translation", translationValue);
                        cmd.Parameters.AddWithValue("@p_language", translations.Item1);
                        cmd.Parameters.AddWithValue("@p_controlName", controlName);
                        cmd.Parameters.AddWithValue("@p_formName", translations.Item2);

                        cmd.ExecuteNonQuery();
                        anyChanges = true;
                    }

                    // Imprimir el control y su traducción
                    Console.WriteLine($"{translations.Item1}, {translations.Item2}, {controlName}, {translationValue}");
                }
            }
            // Retornar si se hizo alguna modificación
            return anyChanges;
        }
    }
}
