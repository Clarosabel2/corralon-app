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
            if (dr.HasRows && dr.Read())
            {
                emps.Add(new BE_Employee(dr));
            }
            return emps;
        }
    }
}
