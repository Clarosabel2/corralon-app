using BDE;
using DAL;
using SVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_EventLog
    {
        public static void LogEvent(BE_Eventlog eventLog)
        {
            Console.WriteLine($"Event logged: {eventLog.Message}");
            DAL_Eventlog.RegisterEventLog(eventLog);
        }

    }
}
