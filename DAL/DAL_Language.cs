using BDE.Composite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVC.LanguageManager;

namespace DAL
{
    public static class DAL_Language
    {
        public static List<string> GetLanguages()
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"SELECT * FROM tb_Idiomas";
            cmd.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                List<string> languages = new List<string>();
                while (dr.Read())
                {
                    languages.Add(dr["nombreIdioma"].ToString());
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
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string language = dr["nombreIdioma"].ToString(), formName = dr["nombreForm"].ToString(), crtl = dr["nombreControl"].ToString(), translation = dr["traduccion"].ToString();

                    if (!LanguageManager.translations.ContainsKey(language))
                    {
                        LanguageManager.translations[language] = new Dictionary<string, Dictionary<string, string>>();
                    }

                    if (!LanguageManager.translations[language].ContainsKey(formName))
                    {
                        LanguageManager.translations[language][formName] = new Dictionary<string, string>();
                    }

                    LanguageManager.translations[language][formName][crtl] = translation;
                }
            }

        }
    }
}
