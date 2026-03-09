using BDE;
using BDE.Language;
using DAL.Interfaces;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public bool BlockById(int id)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"UPDATE Usuarios SET estado = 0 WHERE id_Usuario = @p_id;";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_id", id);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();
            return rowsAffected > 0;
        }

        public void ChangeLanguage(Language language, int idUser)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"sp_ChangeLanguageUser";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_language", language.Name);
            cmd.Parameters.AddWithValue("@p_id_user", idUser);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();
        }

        public bool CheckStatus(int idUser)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"SELECT estado FROM Usuarios WHERE id_Usuario = @p_id_Usuario";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@p_id_Usuario", idUser);

            var result = cmd.ExecuteScalar();
            cmd.Connection = cnn.CloseConnection();

            return result != null && Convert.ToBoolean(result);
        }

        public bool Save(User newUser)
        {

            var cnn = new DbConnectionFactory();
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

        public bool ExistsById(int id)
        {
            bool existeUsuario = false;
            var cnn = new DbConnectionFactory();
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

        public bool ExtisByUsername(string username) {
            return true;
        }

        public List<User> GetAll()
        {
            List<User> users = new List<User>();

            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand
            {
                Connection = cnn.OpenConnection(),
                CommandText = @"SELECT 
                                u.id_Usuario,
                                p.id_Persona,
                                u.username,
                                u.estado,
                                u.[password],
                                r.rol,
                                p.DNI,
                                p.nombre,
                                p.apellido,
                                p.domicilio,
                                p.email,
                                p.telefono
                            FROM Usuarios u
                            INNER JOIN Empleados e ON e.id_Empleado = u.id_Usuario
                            INNER JOIN Personas p ON p.id_Persona = u.id_Usuario
                            INNER JOIN Roles r ON r.id_Rol = u.id_Rol",
                CommandType = CommandType.Text
            };

            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    users.Add(UserMapper.Map(dr));
                }
            }

            cnn.CloseConnection();

            return users;
        }


        public DataTable GetByProfile()
        {
            var cnn = new DbConnectionFactory();
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

        public bool Update(User user)
        {
            try
            {
                var cnn = new DbConnectionFactory();
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

        public bool UpdatePassword(int idUser, string newPassword)
        {
            try
            {
                var cnn = new DbConnectionFactory();
                using (var cmd = new SqlCommand($"UPDATE Usuarios SET password=@newpass WHERE id_Usuario={idUser}", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@newpass", newPassword);
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

        public bool Validate(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return false;

            const string sql = @"
                SELECT TOP(1) 1
                FROM dbo.Usuarios
                WHERE UserName = @u AND [Password] = @p;";

            var cnn = new DbConnectionFactory();
            try
            {
                using (var cmd = new SqlCommand(sql, cnn.Connection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add("@u", SqlDbType.NVarChar, 100).Value = username.Trim();
                    cmd.Parameters.Add("@p", SqlDbType.NVarChar, 256).Value = password;

                    cnn.Connection.Open();
                    object result = cmd.ExecuteScalar();
                    return result != null && result != DBNull.Value; // true si encontró fila
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                if (cnn.Connection.State != ConnectionState.Closed)
                    cnn.Connection.Close();
            }
        }


        public User GetDataUser(string username, string password)
        {
            User user = new User();
            var cnn = new DbConnectionFactory();
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
                    return UserMapper.Map(dr);
                }
            }
            return null;
        }

        public User GetById(int id)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();

            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"select * from Usuarios u
                                left join Roles r on r.id_Rol=u.id_Rol
                                where u.id_Usuario= @p_id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_id", id);

            DataTable table = new DataTable();

            using (var adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(table);
            }

            cnn.CloseConnection();

            if (table.Rows.Count > 0)
                return UserMapper.Map(table.Rows[0]);

            return null;
        }
        public string GetRolUser(int idUser)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"select
                                    r.rol
                                    from Usuarios u
                                    left join Roles r on u.id_Rol=r.id_Rol
                                    where u.id_Usuario=@p_id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_id", idUser);
            object result = cmd.ExecuteScalar();
            cnn.CloseConnection();
            return result?.ToString();
        }

        public bool Unlock(int idUser)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"UPDATE Usuarios SET estado = 1 WHERE id_Usuario = @p_id;";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_id", idUser);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();
            return rowsAffected > 0;
        }

        

        public void ResetPassword(int id, string passwordHashed)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"UPDATE Usuarios set [password]=@p_passHashed where id_Usuario=@p_id";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_id", id);
            cmd.Parameters.AddWithValue("@p_passHashed", passwordHashed);
            cmd.ExecuteNonQuery();
            cnn.CloseConnection();
        }

        

        

        public bool BlockByUsername(int username)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"UPDATE Usuarios SET estado = 0 WHERE username = @p_username;";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_username", username);
            int rowsAffected = cmd.ExecuteNonQuery();
            cmd.Connection = cnn.CloseConnection();
            return rowsAffected > 0;
        }

        public bool BlockByUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
