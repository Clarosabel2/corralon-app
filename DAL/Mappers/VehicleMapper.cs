using BDE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
    public class VehicleMapper
    {
        public static Vehicle Map(SqlDataReader dr)
        {
            var vehicle = new Vehicle(
                dr.GetString(dr.GetOrdinal("patente")),
                dr.GetString(dr.GetOrdinal("marca")),
                dr.GetString(dr.GetOrdinal("modelo")),
                dr.GetInt32(dr.GetOrdinal("anio")),
                dr.GetInt32(dr.GetOrdinal("cant_ejes")),
                dr.GetInt32(dr.GetOrdinal("carga_max"))
            );

            vehicle.EntryDate = dr.GetDateTime(dr.GetOrdinal("fecha_ingreso"));

            return vehicle;
        }

        public static Vehicle Map(DataRow row)
        {
            var vehicle = new Vehicle(
                row.Field<string>("patente"),
                row.Field<string>("marca"),
                row.Field<string>("modelo"),
                row.Field<int>("anio"),
                row.Field<int>("cant_ejes"),
                row.Field<int>("carga_max")
            );

            vehicle.EntryDate = row.Field<DateTime>("fecha_ingreso");

            return vehicle;
        }
    }
}
