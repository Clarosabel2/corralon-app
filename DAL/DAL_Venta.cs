using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE;

namespace DAL
{
    public class DAL_Venta : DAL_Conexion
    {
        public static DataTable GetTypesInvoice()
        {
            var cnn = new DAL_Conexion();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT t.id_Tipo, t.tipo FROM TipoFactura t", cnn.Connection);
            adapter.SelectCommand.CommandType = CommandType.Text;
            adapter.Fill(table);
            return table;
        }

        public static void SaveInvoice(BE_Venta newSale)
        {
            throw new NotImplementedException();
        }
    }
}
