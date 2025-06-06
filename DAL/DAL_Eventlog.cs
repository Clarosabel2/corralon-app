using BDE;
using BDE.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class DAL_Eventlog
    {
        public static bool RegisterEventLog(BE_Eventlog eventLog)
        {
            var cnn = new DAL_Connection();
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
                cmd.ExecuteNonQuery();

                return cmd.ExecuteNonQuery() > 0;
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
