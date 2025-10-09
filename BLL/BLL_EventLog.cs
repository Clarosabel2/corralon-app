using BDE;
using BDE.Enums;
using DAL;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_EventLog
    {
        public static DataTable LoadEventlogs()
        {
            DataTable dt = DAL_Eventlog.GetEventLogs();
            foreach (DataRow row in dt.Rows)
            {
                if (row["eventTime"] != DBNull.Value)
                {
                    TimeSpan hora = (TimeSpan)row["eventTime"];
                    row["eventTime"] = new TimeSpan(hora.Hours, hora.Minutes, hora.Seconds);
                }
            }
            return dt;
        }

        public static void LogEvent(string message, BE_EventType eventType, BE_ActivityLevel activity)
        {
            BE_Eventlog newEvent = new BE_Eventlog(
                SessionManager.GetInstance.user.Emp.Id,
                message, eventType, activity);

            Console.WriteLine($"Event logged: {message}");
            DAL_Eventlog.RegisterEventLog(newEvent);
        }

    }
}
