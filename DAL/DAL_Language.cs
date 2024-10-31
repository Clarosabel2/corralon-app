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
                        IsDefault = Convert.ToBoolean(dr["default"].ToString())
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
            SessionManager.translations = new Dictionary<BE_Language, Dictionary<string, Dictionary<string, string>>>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string languageName = dr["nombreIdioma"].ToString(), formName = dr["nombreForm"].ToString(),
                        crtl = dr["nombreControl"].ToString(), translation = dr["traduccion"].ToString();

                    var language = languages.FirstOrDefault(x => x.Name.Equals(languageName, StringComparison.OrdinalIgnoreCase));

                    if (language == null) {
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
            LanguageManager.CurrentLanguage = SessionManager.translations.FirstOrDefault(l => l.Key.IsDefault).Key;
            
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
    }
}
