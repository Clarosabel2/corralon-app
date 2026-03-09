using BDE;
using BDE.Enums;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class EventLogRepository : IEventlogRepository
    {
        public DataTable GetLogs()
        {
            var cnn = new DbConnectionFactory();
            try
            {
                using (var cmd = new SqlCommand("sp_GetEventlogs", cnn.OpenConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var adapter = new SqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los logs: " + ex.Message);
            }
            finally
            {
                cnn.CloseConnection();
            }
        }


        public bool SaveLog(Eventlog eventLog)
        {
            var cnn = new DbConnectionFactory();
            try
            {
                var cmd = new SqlCommand
                {
                    Connection = cnn.OpenConnection(),
                    CommandText = "sp_InsertEventLog",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@p_userId", eventLog.UserId);
                cmd.Parameters.AddWithValue("@p_message", eventLog.Message);
                cmd.Parameters.AddWithValue("@p_eventDate", eventLog.EventDate.Date);
                cmd.Parameters.AddWithValue("@p_eventTime", eventLog.EventTime);
                cmd.Parameters.AddWithValue("@p_id_type_event", (int)(BE_EventType)eventLog.EventType);
                cmd.Parameters.AddWithValue("@p_id_activity_level", (int)(BE_ActivityLevel)eventLog.ActivityLevel);
                int result = cmd.ExecuteNonQuery();
                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al registrar eventlog: " + ex.Message);
            }
            finally
            {

                cnn.CloseConnection();
            }
        }
    }
}
