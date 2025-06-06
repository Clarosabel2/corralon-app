using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_Eventlog
    {
        private int _userId;
        private string _message;
        private Enum _eventType;
        private Enum _activityLevel;
        private DateTime _eventDate;
        private TimeSpan _eventTime;

        public BE_Eventlog(int userId, string message, Enum eventType, Enum activityLevel)
        {
            _userId = userId;
            _message = message;
            _eventDate = DateTime.Now;
            _eventTime = DateTime.Now.TimeOfDay;
            _eventType = eventType;
            _activityLevel = activityLevel;
        }

        public int UserId { get => _userId; set => _userId = value; }
        public string Message { get => _message; set => _message = value; }
        public DateTime EventDate { get => _eventDate; set => _eventDate = value; }
        public TimeSpan EventTime { get => _eventTime; set => _eventTime = value; }
        public Enum EventType
        {
            get => _eventType; set => _eventType = value;
        }
        public Enum ActivityLevel { get => _activityLevel; set => _activityLevel = value; }
    }
}
