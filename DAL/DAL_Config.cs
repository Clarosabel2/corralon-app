using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Config
    {
        public static string GetValue(string key)
        {
            var ocnn = new DAL_Connection();
            try
            {
                var cnn = ocnn.OpenConnection(); // Abre la conexión
                using (var cmd = new SqlCommand("SELECT valor FROM Config_Sistema WHERE clave = @key", cnn))
                {
                    cmd.Parameters.AddWithValue("@key", key);
                    var result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error obteniendo el valor para clave '{key}': {ex.Message}", ex);
            }
            finally
            {
                ocnn.CloseConnection(); 
            }
        }

        public static void SetValue(string key, string value)
        {
            var ocnn = new DAL_Connection();
            try
            {
                var cnn = ocnn.OpenConnection();
                using (var cmd = new SqlCommand(
                    "IF EXISTS (SELECT 1 FROM Config_Sistema WHERE clave = @key) " +
                    "UPDATE Config_Sistema SET valor = @value WHERE clave = @key " +
                    "ELSE INSERT INTO Config_Sistema (clave, valor) VALUES (@key, @value)", cnn))
                {
                    cmd.Parameters.AddWithValue("@key", key);
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error guardando el valor para clave '{key}': {ex.Message}", ex);
            }
            finally
            {
                ocnn.CloseConnection();
            }
        }
    }
}
