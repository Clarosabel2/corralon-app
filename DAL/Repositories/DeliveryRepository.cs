using BDE;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class DeliveryRepository : IDeliveryRepository
    {
        private readonly ISaleRepository _saleRepository;
        private readonly IEmployeeRepository _employeeRepository;

        public DeliveryRepository(ISaleRepository saleRepository, IEmployeeRepository employeeRepository)
        {
            _saleRepository = saleRepository;
            _employeeRepository = employeeRepository;
        }

        public void Dispatch(int id_invoice, Employee dealer, DateTime departureTime)
        {
            try
            {
                var cnn = new DbConnectionFactory();
                var cmd = new SqlCommand
                {
                    Connection = cnn.OpenConnection(),
                    CommandText = "UPDATE Pedidos SET id_Empleado=@p_idEmployee, hora_salida=@p_departuraTime  where id_Factura=@p_idInvoice",
                    CommandType = CommandType.Text
                };
                cmd.Parameters.AddWithValue("@p_idInvoice", id_invoice);
                cmd.Parameters.AddWithValue("@p_idEmployee", dealer.Id);
                cmd.Parameters.AddWithValue("@p_departuraTime", departureTime);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable GetAllPending()
        {
            var cnn = new DbConnectionFactory();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("sp_GetAllPendingOrder", cnn.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.Fill(table);
            return table;
        }

        public DataTable GetDispatched()
        {
            var cnn = new DbConnectionFactory();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("sp_GetOrdersDepatched"
                , cnn.Connection);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.AddWithValue("@status", 0);
            adapter.Fill(table);
            return table;
        }

        public void MarkAsDelivered(int idInvoice)
        {
            try
            {
                var cnn = new DbConnectionFactory();
                var cmd = new SqlCommand
                {
                    Connection = cnn.OpenConnection(),
                    CommandText = "UPDATE Pedidos SET estado = 1, hora_llegada = @hora_llegada WHERE id_Factura = @p_idInvoice",
                    CommandType = CommandType.Text
                };

                cmd.Parameters.AddWithValue("@hora_llegada", DateTime.Now);
                cmd.Parameters.AddWithValue("@p_idInvoice", idInvoice);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public List<Delivery> GetDelivered()
        {
            List<Delivery> list = new List<Delivery>();

            var cnn = new DbConnectionFactory();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Pedidos where estado=@p_status"
                , cnn.Connection);
            adapter.SelectCommand.CommandType = CommandType.Text;
            adapter.SelectCommand.Parameters.AddWithValue("@p_status", 1);
            adapter.Fill(table);

            foreach (DataRow r in table.Rows)
            {
                list.Add(new Delivery
                {
                    DeliveryDate = r.Field<DateTime>("fecha_entrega"),
                    Status = r.Field<bool>("estado"),
                    DepartureDate = r.Field<DateTime?>("hora_salida") ?? default(DateTime),
                    ArrivalDate = r.Field<DateTime?>("hora_llegada") ?? default(DateTime),
                    Dealer = _employeeRepository.GetById(r.Field<int>("id_Empleado")) ?? throw new Exception("id empleado null"),
                    Sale = _saleRepository.GetById(r.Field<int>("id_Factura")) ?? throw new Exception("id factura null"),
                });
            }

            return list;
        }

        public void Save(Delivery delivery)
        {
            throw new NotImplementedException();
        }
    }
}
