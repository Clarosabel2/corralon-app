using BDE;
using BDE.Enums;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EventlogService : IEventlogService
    {
        private readonly IEventlogRepository _eventlogRepository;

        public EventlogService(IEventlogRepository eventlogRepository)
        {
            _eventlogRepository = eventlogRepository;
        }

        public DataTable GetLogs()
        {
            DataTable dt = _eventlogRepository.GetLogs();
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

        public void LogEvent(string message, BE_EventType eventType, BE_ActivityLevel activity)
        {
            Eventlog newEvent = new Eventlog(
                SessionManager.GetInstance.user.Emp.Id,
                message, eventType, activity);

            Console.WriteLine($"Event logged: {message}");
            _eventlogRepository.SaveLog(newEvent);
        }

    }
}
