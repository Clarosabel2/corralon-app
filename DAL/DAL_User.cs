﻿using BDE;
using BDE.Language;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public static class DAL_User
    {
        public static void BlockUserByUsername(string username)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"UPDATE Usuarios SET estado = 0 WHERE username = @p_username;";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_username", username);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();
        }
        public static bool BlockUserById(int id)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"UPDATE Usuarios SET estado = 0 WHERE id_Usuario = @p_id;";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_id", id);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();
            return rowsAffected > 0;
        }

        public static void ChangeLanguageUser(BE_Language language, int idUser)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"sp_ChangeLanguageUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_language", language.Name);
            cmd.Parameters.AddWithValue("@p_id_user", idUser);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();
        }

        public static bool CheckStatusUser(int idUser)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"SELECT estado FROM Usuarios WHERE id_Usuario = @p_id_Usuario";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p_id_Usuario", idUser);

            var result = cmd.ExecuteScalar();
            cmd.Connection = cnn.CloseConnection();

            return result != null && Convert.ToBoolean(result);
        }

        public static bool CreateUser(BE_User newUser)
        {

            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"sp_SaveNewUser";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@p_id_Usuario", newUser.Emp.Id);
            cmd.Parameters.AddWithValue("@p_id_Idioma", newUser.Language);
            cmd.Parameters.AddWithValue("@p_name_Rol", newUser.Rol.ToString());
            cmd.Parameters.AddWithValue("@p_username", newUser.Username);
            cmd.Parameters.AddWithValue("@p_password", newUser.Password);

            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();

            return rowsAffected > 0;
        }

        public static bool ExistUser(int id)
        {
            bool existeUsuario = false;
            var cnn = new DAL_Connection();
            using (var cmd = new SqlCommand($"SELECT IIF(EXISTS (\r\n  SELECT 1 FROM Usuarios u WHERE u.id_Usuario = @id\r\n), CAST(1 AS BIT), CAST(0 AS BIT)) AS Existe;", cnn.OpenConnection()))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", id);

                var result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    existeUsuario = Convert.ToBoolean(result);
                }
            }
            return existeUsuario;
        }

        public static DataTable GetAllUsers()
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand
            {
                Connection = cnn.OpenConnection(),
                CommandText = "SELECT \r\n\tu.id_Usuario,\r\n\tp.email,\r\n\tu.username,\r\n\tu.[password],\r\n\tp.DNI,\r\n\tp.nombre,\r\n\tp.apellido,\r\n\tr.rol \r\nFROM Usuarios u \r\n\tINNER JOIN Empleados e on e.id_Empleado=u.id_Usuario \r\n\tINNER JOIN Personas p on p.id_Persona=u.id_Usuario \r\n\tINNER JOIN Roles r on r.id_Rol=u.id_Rol",
                CommandType = CommandType.Text
            };
            var dataTable = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dataTable.Load(dr);
            }
            dr.Close();
            return dataTable;
        }

        public static DataTable GetUserByProfile()
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand
            {
                Connection = cnn.OpenConnection(),
                CommandText = "SELECT u.id_Usuario,u.username,CONCAT(p.apellido,', ',p.nombre) AS Empleado FROM Usuarios u INNER JOIN Empleados e on e.id_Empleado=u.id_Usuario INNER JOIN Personas p on p.id_Persona=u.id_Usuario",
                CommandType = CommandType.Text
            };
            var dataTable = new DataTable();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dataTable.Load(dr);
            }
            dr.Close();
            return dataTable;
        }

        public static bool UpdateUserData(BE_User user)
        {
            try
            {
                var cnn = new DAL_Connection();
                using (var cmd = new SqlCommand($"UPDATE Personas SET nombre=@name, apellido=@lastname, email=@email WHERE id_Persona={user.Emp.Id}", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@name", user.Emp.Name);
                    cmd.Parameters.AddWithValue("@lastname", user.Emp.Lastname);
                    cmd.Parameters.AddWithValue("@email", user.Emp.Email);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        public static bool UpdateUserPasswordByIdUser(string password, int idUser)
        {
            try
            {
                var cnn = new DAL_Connection();
                using (var cmd = new SqlCommand($"UPDATE Usuarios SET password=@newpass WHERE id_Usuario={idUser}", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@newpass", password);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }

        public static BE_User ValidUser(string username, string password)
        {
            BE_User user = new BE_User();
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_ValidUser";
            cmd.Parameters.AddWithValue("@p_username", username);
            cmd.Parameters.AddWithValue("@p_password", password);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    user = new BE_User(
                         dr.GetString(dr.GetOrdinal("username")),
                         dr.GetBoolean(dr.GetOrdinal("estado")),
                         (BE_TypeUser)Enum.Parse(typeof(BE_TypeUser), dr.GetString(dr.GetOrdinal("rol"))),
                         dr.GetString(dr.GetOrdinal("password")),
                         new BE_Employee(
                             dr.GetInt32(dr.GetOrdinal("id_Persona")),
                             dr.GetInt32(dr.GetOrdinal("DNI")),
                             dr.GetString(dr.GetOrdinal("nombre")),
                             dr.GetString(dr.GetOrdinal("apellido")),
                             dr.GetString(dr.GetOrdinal("domicilio")),
                             dr.GetString(dr.GetOrdinal("email")),
                             dr.GetInt32(dr.GetOrdinal("telefono")),
                             0.0,
                             dr.GetString(dr.GetOrdinal("nombreArea"))));
                    user.Language = DAL_Language.GetLanguage(dr.GetString(dr.GetOrdinal("nombreIdioma")));
                    return user;
                }
            }
            return null;
        }

        public static bool UnlockUserById(int id)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"UPDATE Usuarios SET estado = 1 WHERE id_Usuario = @p_id;";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_id", id);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();
            return rowsAffected > 0;
        }
    }
}
