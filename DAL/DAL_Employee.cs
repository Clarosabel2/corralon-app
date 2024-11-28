using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVC;
using BDE;
using System.Net;

namespace DAL
{
    public class DAL_Employee
    {
        public static List<BE_Employee> GetAllEmployeesWithoutUser()
        {
            List<BE_Employee> emps = new List<BE_Employee>();
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "SELECT p.id_Persona, p.DNI, p.nombre, p.apellido, p.email, p.telefono, p.domicilio, a.nombreArea FROM Empleados emp INNER JOIN Personas p ON p.id_Persona=emp.id_Empleado INNER JOIN Areas a ON emp.id_Area=a.id_Area LEFT JOIN Usuarios u ON u.id_Usuario=p.id_Persona WHERE u.id_Usuario IS NULL;";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                emps.Add(InstanceEmployee(dr));
            }
            return emps;
        }
        public static List<BE_Employee> GetAllEmployees()
        {
            List<BE_Employee> emps = new List<BE_Employee>();
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "SELECT p.id_Persona, p.DNI, p.nombre, p.apellido, p.email, p.telefono, p.domicilio, a.nombreArea FROM Empleados emp INNER JOIN Personas p ON p.id_Persona=emp.id_Empleado INNER JOIN Areas a ON emp.id_Area=a.id_Area";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                emps.Add(InstanceEmployee(dr));
            }
            return emps;
        }

        public static List<BE_Employee> GetEmployeesByArea(string area)
        {
            List<BE_Employee> emps = new List<BE_Employee>();
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_GetEmployeesByArea";
            cmd.Parameters.AddWithValue("@p_area", area);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                emps.Add(InstanceEmployee(dr));
            }
            return emps;
        }
        public static bool SaveEmployee(BE_Employee emp)
        {
            var cnn = new DAL_Connection();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"sp_SaveEmployee";
            cmd.Parameters.AddWithValue("@p_dni", emp.Dni);
            cmd.Parameters.AddWithValue("@p_name", emp.Name);
            cmd.Parameters.AddWithValue("@p_lastname", emp.Lastname);
            cmd.Parameters.AddWithValue("@p_address", emp.Address);
            cmd.Parameters.AddWithValue("@p_email", emp.Email);
            cmd.Parameters.AddWithValue("@p_phone", emp.NumPhone);
            cmd.Parameters.AddWithValue("@p_area", emp.Area);
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd.ExecuteNonQuery() > 0;
        }
        private static BE_Employee InstanceEmployee(SqlDataReader dr)
        {
            return new BE_Employee(
                             dr.GetInt32(dr.GetOrdinal("id_Persona")),
                             dr.GetInt32(dr.GetOrdinal("DNI")),
                             dr.GetString(dr.GetOrdinal("nombre")),
                             dr.GetString(dr.GetOrdinal("apellido")),
                             dr.GetString(dr.GetOrdinal("domicilio")),
                             dr.GetString(dr.GetOrdinal("email")),
                             dr.GetInt32(dr.GetOrdinal("telefono")),
                             0.0,
                             dr.GetString(dr.GetOrdinal("nombreArea")));
        }
    }
}
