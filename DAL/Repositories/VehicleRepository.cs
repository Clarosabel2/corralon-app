using BDE;
using DAL.Interfaces;
using DAL.Mappers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class VehicleRepository : IVehicleRepository
    {
        public List<Vehicle> GetAll()
        {
            var cnn = new DbConnectionFactory();
            var table = new DataTable();
            var vehicles = new List<Vehicle>();

            try
            {
                var cmd = new SqlCommand
                {
                    Connection = cnn.OpenConnection(),
                    CommandText = "SELECT * FROM Vehiculos",
                    CommandType = CommandType.Text
                };

                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    vehicles.Add(VehicleMapper.Map(row));
                }

                return vehicles;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                cnn.CloseConnection();
            }
        }


        public bool Save(Vehicle v)
        {
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand();

            try
            {
                
                cmd.Connection = cnn.OpenConnection();
                cmd.CommandText = "INSERT INTO Vehiculos (patente, marca, modelo, anio, cant_ejes, carga_max, fecha_ingreso) " +
                                  "VALUES (@patente, @marca, @modelo, @anio, @cant_ejes, @carga_max, @fecha_ingreso)";
                cmd.CommandType = CommandType.Text;

                
                cmd.Parameters.AddWithValue("@patente", v.Patent);
                cmd.Parameters.AddWithValue("@marca", v.Brand);
                cmd.Parameters.AddWithValue("@modelo", v.Model);
                cmd.Parameters.AddWithValue("@anio", v.Year);

                
                cmd.Parameters.AddWithValue("@cant_ejes", v.NumberAxles);
                cmd.Parameters.AddWithValue("@carga_max", v.TareWeight);

                
                cmd.Parameters.AddWithValue("@fecha_ingreso", v.EntryDate);

                
                int filasAfectadas = cmd.ExecuteNonQuery();

                
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                cnn.CloseConnection();
            }
        }
    }
}
