using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Invoice
    {
        public static DataRow GetClientByIdInvoice(int idInvoice)
        {
            var cnn = new DAL_Connection();
            using (cnn.OpenConnection())
            {
                DataTable table = new DataTable();
                string query = @"
                                SELECT p.*
                                FROM Personas p
                                INNER JOIN Facturas f ON f.id_Cliente = p.id_Persona
                                WHERE f.id_Factura = @idFactura";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, cnn.Connection))
                {
                    adapter.SelectCommand.CommandType = CommandType.Text;
                    adapter.SelectCommand.Parameters.AddWithValue("@idFactura", idInvoice);
                    adapter.Fill(table);
                }
                return table.Rows.Count > 0 ? table.Rows[0] : null;
            }
        }

        public static DataTable GetTypesInvoice()
        {
            var cnn = new DAL_Connection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT t.id_Tipo, t.tipo FROM TipoFactura t", cnn.Connection);
            adapter.SelectCommand.CommandType = CommandType.Text;
            adapter.Fill(table);
            return table;
        }
    }
}
