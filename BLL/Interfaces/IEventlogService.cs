using BDE;
using BDE.Enums;
using System.Data;

namespace BLL.Interfaces
{
    public interface IEventlogService
    {
        DataTable GetLogs();
        void LogEvent(string message, BE_EventType eventType, BE_ActivityLevel activityLevel);
    }
}