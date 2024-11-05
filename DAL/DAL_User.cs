using BDE;
using SVC;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE.Language;

namespace DAL
{
    public static class DAL_User
    {
        public static void BlockUser(string username)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"UPDATE Usuarios SET estado = 1 WHERE username = @p_username;";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_username", username);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();
        }

        public static void ChangeLanguageUser(BE_Language language)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"sp_ChangeLanguageUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_language", language.Name);
            cmd.Parameters.AddWithValue("@p_id_user", SessionManager.GetInstance.user.Emp.Id);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();
        }

        public static bool UpdateUserData(BE_User user)
        {
            try
            {
                var cnn = new DAL_Connection();
                using (var cmd = new SqlCommand($"UPDATE Personas SET nombre=@name, apellido=@lastname, email=@email WHERE id_Persona={SessionManager.GetInstance.user.Emp.Id}", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", user.Emp.Name);
                    cmd.Parameters.AddWithValue("@lastname", user.Emp.Lastname);
                    cmd.Parameters.AddWithValue("@email", user.Emp.Email);
                    cmd.ExecuteNonQuery();
                }
                SessionManager.GetInstance.user.Emp.Name= user.Emp.Name;
                SessionManager.GetInstance.user.Emp.Lastname= user.Emp.Lastname;
                SessionManager.GetInstance.user.Emp.Email= user.Emp.Email;

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateUserPasswordById(string password)
        {
            try
            {
                var cnn = new DAL_Connection();
                using (var cmd = new SqlCommand($"UPDATE Usuarios SET password=@newpass WHERE id_Usuario={SessionManager.GetInstance.user.Emp.Id}", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@newpass", password);
                    cmd.ExecuteNonQuery();
                }
                SessionManager.GetInstance.user.Password = password;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static bool ValidUser(string username, string password)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_ValidUser";
            cmd.Parameters.AddWithValue("@p_username", username);
            cmd.Parameters.AddWithValue("@p_password", EncodeManager.HashValue(password));
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    SessionManager.Login(new BE_User(dr));
                    SessionManager.GetInstance.user.Language = SessionManager.translations.FirstOrDefault(l => l.Key.Name == dr.GetString(dr.GetOrdinal("nombreIdioma"))).Key;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
