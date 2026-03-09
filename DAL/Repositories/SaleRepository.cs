using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BDE;
using System.Net;
using DAL.Interfaces;
using DAL.Mappers;

namespace DAL.Repositories
{
    public class SaleRepository : DbConnectionFactory, ISaleRepository
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IClientRepository _clientRepository;

        public SaleRepository(IEmployeeRepository employeeRepository, IClientRepository clientRepository)
        {
            _employeeRepository = employeeRepository;
            _clientRepository = clientRepository;
        }

        public Sale GetById(int idSale)
        {
            Sale sale = new Sale();
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand
            {
                Connection = cnn.OpenConnection(),
                CommandText = "SELECT * FROM Facturas WHERE id_Factura = @p_idFactura",
                CommandType = CommandType.Text
            };
            cmd.Parameters.AddWithValue("@p_idFactura", idSale.ToString());

            DataTable dataTable = new DataTable();

            try
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataTable.Load(reader);
                    }
                }

                if (dataTable.Rows.Count > 0)
                {
                    DataRow r = dataTable.Rows[0];
                    return new Sale(
                        r.Field<int>("id_Factura"),
                        'A',
                        r.Field<DateTime>("fecha"),
                        _clientRepository.GetById(r.Field<int>("id_Cliente")),
                        _employeeRepository.GetById(r.Field<int>("id_Empleado")),
                        GetItemsBySaleId(idSale),
                        r.Field<double>("total"),
                        Convert.ToBoolean(r["estado"])
                    );
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener la factura por ID: " + ex.Message, ex);
            }
            finally
            {
                cnn.CloseConnection();
            }
        }

        public List<Item> GetItemsBySaleId(int saleId)
        {
            List<Item> items = new List<Item>();
            var cnn = new DbConnectionFactory();
            var cmd = new SqlCommand
            {
                Connection = cnn.OpenConnection(),
                CommandText = "sp_GetProductsByInvoice",
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@p_idFactura", saleId);
            var dataTable = new DataTable();

            try
            {
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dataTable.Load(dr);
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los productos por factura: " + ex.Message, ex);
            }
            finally
            {
                cnn.CloseConnection();
            }
            int i = 0;
            foreach (DataRow r in dataTable.Rows)
            {
                i++;
                items.Add(new Item(i, ProductMapper.Map(r), r.Field<int>("cantidad"))); // agregar subtotal al constructor de Item si es necesario
            }


            return items;
        }

        public DataTable GetTypes()
        {
            var cnn = new DbConnectionFactory();
            DataTable table = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT t.id_Tipo, t.tipo FROM TipoFactura t", cnn.Connection);

            adapter.SelectCommand.CommandType = CommandType.Text;
            adapter.Fill(table);
            return table;
        }

        public void Save(Sale sale, out int saleId)
        {
            try
            {
                var cnn = new DbConnectionFactory();

                using (var cmd = new SqlCommand("sp_SaveInvoice", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idCliente", sale.Client.Id);
                    cmd.Parameters.AddWithValue("@idEmpleado", sale.Saleman.Id);
                    cmd.Parameters.AddWithValue("@TipoFactura", sale.TypeInvoice);
                    cmd.Parameters.AddWithValue("@total", sale.Total);
                    cmd.Parameters.AddWithValue("@estadoFactura", sale.Status);
                    cmd.Parameters.AddWithValue("@fechaEmision", sale.IssueDate);

                    SqlParameter outputIdParam = new SqlParameter("@@newInvoiceID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(outputIdParam);
                    cmd.ExecuteNonQuery();
                    saleId = (int)outputIdParam.Value;
                }

                foreach (var item in sale.ItemsProducts)
                {
                    using (var itemCmd = new SqlCommand("sp_SaveItemsInvoice", cnn.OpenConnection()))
                    {
                        itemCmd.CommandType = CommandType.StoredProcedure;
                        itemCmd.Parameters.AddWithValue("@idProducto", item.Product.Id);
                        itemCmd.Parameters.AddWithValue("@idFactura", saleId);
                        itemCmd.Parameters.AddWithValue("@cantidad", item.Amount);
                        itemCmd.Parameters.AddWithValue("@precio_unitario", item.Product.Price);
                        itemCmd.ExecuteNonQuery();
                    }
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        public void SaveWithDelivery(Delivery delivery)
        {
            int saleId;
            try
            {
                var cnn = new DbConnectionFactory();

                using (var cmd = new SqlCommand("sp_SaveInvoice", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idCliente", delivery.Sale.Client.Id);
                    cmd.Parameters.AddWithValue("@idEmpleado", delivery.Sale.Saleman.Id);
                    cmd.Parameters.AddWithValue("@TipoFactura", delivery.Sale.TypeInvoice);
                    cmd.Parameters.AddWithValue("@total", delivery.Sale.Total);
                    cmd.Parameters.AddWithValue("@estadoFactura", delivery.Sale.Status);
                    cmd.Parameters.AddWithValue("@fechaEmision", delivery.Sale.IssueDate);

                    SqlParameter outputIdParam = new SqlParameter("@@newInvoiceID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(outputIdParam);
                    cmd.ExecuteNonQuery();
                    saleId = (int)outputIdParam.Value;
                }

                foreach (var item in delivery.Sale.ItemsProducts)
                {
                    using (var itemCmd = new SqlCommand("sp_SaveItemsInvoice", cnn.OpenConnection()))
                    {
                        itemCmd.CommandType = CommandType.StoredProcedure;
                        itemCmd.Parameters.AddWithValue("@idProducto", item.Product.Id);
                        itemCmd.Parameters.AddWithValue("@idFactura", saleId);
                        itemCmd.Parameters.AddWithValue("@cantidad", item.Amount);
                        itemCmd.Parameters.AddWithValue("@precio_unitario", item.Product.Price);
                        itemCmd.ExecuteNonQuery();
                    }
                }


            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
