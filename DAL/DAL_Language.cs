using BDE.Language;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class DAL_Language
    {
        public static BE_Language GetLanguage(string languageName)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"select * from tb_Idiomas where nombreIdioma=@p_languageName";
            cmd.Parameters.AddWithValue("@p_languageName", languageName);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    return new BE_Language(
                        dr["nombreIdioma"].ToString(),
                         dr["language_code"].ToString(),
                         Convert.ToBoolean(dr["default"].ToString())
                         );
                }
            }
            return null;
        }
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


        public static DataTable GetTranslationsDataTable()
        {
            var cnn = new DAL_Connection();
            using (var cmd = new SqlCommand("sp_GetTraductions", cnn.OpenConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (var da = new SqlDataAdapter(cmd))
                {
                    var dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
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
        public static void InsertTranslation(string languageName, string formName, string controlName, string translationValue)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
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
            cmd.Parameters.AddWithValue("@p_language", languageName);
            cmd.Parameters.AddWithValue("@p_controlName", controlName);
            cmd.Parameters.AddWithValue("@p_formName", formName);

            cmd.ExecuteNonQuery();
        }

        public static void UpdateTranslation(string languageName, string formName, string controlName, string translationValue)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"UPDATE idioma_control SET traduccion=@p_translation
                        WHERE id_Idioma=(SELECT TOP 1 i.id_Idioma FROM tb_Idiomas i WHERE i.nombreIdioma=@p_language)
                        AND id_Control=(SELECT TOP 1 c.id_Control 
                            FROM tb_Controles c 
                            INNER JOIN tb_Forms f ON f.id_Form=c.id_Form
                            WHERE c.nombreControl=@p_controlName AND f.nombreForm=@p_formName);";

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@p_translation", translationValue);
            cmd.Parameters.AddWithValue("@p_language", languageName);
            cmd.Parameters.AddWithValue("@p_controlName", controlName);
            cmd.Parameters.AddWithValue("@p_formName", formName);

            cmd.ExecuteNonQuery();
        }
    }
}
