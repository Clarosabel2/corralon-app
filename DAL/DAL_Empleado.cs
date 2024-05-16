using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVC;
using BDE;

namespace DAL
{
    public class DAL_Empleado : DAL_Conexion
    {
        public bool _validUser(string username, string password)
        {

            using (var Connection = GetSqlConnection())
            {
                Connection.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = Connection;
                    cmd.CommandText = "SELECT * FROM Persona INNER JOIN Empleado " +
                        "ON Persona.id_Persona = Empleado.id_Empleado " +
                        "AND Empleado.username=@username " +
                        "AND Empleado.password = @password";
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            BE_Empleado user = new BE_Empleado(
                                dr.GetInt32(0),//ID
                                dr.GetInt32(1),//DNI
                                dr.GetString(2),//NOMBRE
                                dr.GetString(3),//APELLIDO
                                dr.GetString(4),//DOMOCILIO
                                dr.GetString(5),//EMAIL
                                dr.GetInt32(6), //TELEFONO
                                (dr.GetInt32(8)).ToString(),//AREA
                                dr.GetDouble(9), //SALARIO
                                dr.GetString(10), //USERNAME
                                dr.GetString(11));//PASSWORD
                            SessionManager.Login(user);
                            
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
    }
}
