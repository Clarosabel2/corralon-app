using BDE;
using DAL.Interfaces;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetAllEmployeesWithoutUser()
        {
            List<Employee> emps = new List<Employee>();
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "SELECT p.id_Persona, p.DNI, p.nombre, p.apellido, p.email, p.telefono, p.domicilio, a.nombreArea FROM Empleados emp INNER JOIN Personas p ON p.id_Persona=emp.id_Empleado INNER JOIN Areas a ON emp.id_Area=a.id_Area LEFT JOIN Usuarios u ON u.id_Usuario=p.id_Persona WHERE u.id_Usuario IS NULL;";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                emps.Add(EmployeeMapper.Map(dr));
            }
            return emps;
        }
        public List<Employee> GetAllEmployees()
        {
            List<Employee> emps = new List<Employee>();
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "SELECT p.id_Persona, p.DNI, p.nombre, p.apellido, p.email, p.telefono, p.domicilio, a.nombreArea FROM Empleados emp INNER JOIN Personas p ON p.id_Persona=emp.id_Empleado INNER JOIN Areas a ON emp.id_Area=a.id_Area";
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                emps.Add(EmployeeMapper.Map(dr));
            }
            return emps;
        }

        public List<Employee> GetEmployeesByArea(string area)
        {
            List<Employee> emps = new List<Employee>();
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = "sp_GetEmployeesByArea";
            cmd.Parameters.AddWithValue("@p_area", area);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                emps.Add(EmployeeMapper.Map(dr));
            }
            return emps;
        }

        public bool Save(Employee emp)
        {
            var cnn = new DbConnectionFactory();
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

        public bool Update(Employee emp)
        {
            try
            {
                var cnn = new DbConnectionFactory();
                using (var connection = cnn.OpenConnection())
                using (var cmd = new SqlCommand("sp_UpdateEmployee", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id_Persona", emp.Id);
                    cmd.Parameters.AddWithValue("@DNI", emp.Dni);
                    cmd.Parameters.AddWithValue("@nombre", emp.Name);
                    cmd.Parameters.AddWithValue("@apellido", emp.Lastname);
                    cmd.Parameters.AddWithValue("@email", emp.Email);
                    cmd.Parameters.AddWithValue("@telefono", emp.NumPhone);
                    cmd.Parameters.AddWithValue("@domicilio", emp.Address);
                    cmd.Parameters.AddWithValue("@nombreArea", emp.Area);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar empleado: " + ex.Message);
                return false;
            }
        }
        public Employee GetById(int idEmp)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();
            cmd.Connection = cnn.OpenConnection();
            cmd.CommandText = @"select * from Empleados e LEFT JOIN  Personas p
                                ON e.id_Empleado = p.id_Persona
                                WHERE id_Empleado = @p_idEmp";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@p_idEmp", idEmp);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                return EmployeeMapper.Map(dr);
            }
            return null;
        }

        public bool ExistsByDNI(int dni)
        {
            try
            {
                var cnn = new DbConnectionFactory();
                var cmd = new SqlCommand();
                cmd.Connection = cnn.OpenConnection();
                cmd.CommandText = @"
                    SELECT COUNT(*) 
                    FROM Personas p 
                    RIGHT JOIN Empleados e ON p.id_Persona = e.id_Empleado
                    WHERE DNI = @p_dni";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@p_dni", dni);

                object result = cmd.ExecuteScalar();
                int count = (result == DBNull.Value || result == null)
                                ? 0
                                : Convert.ToInt32(result);

                return count > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
