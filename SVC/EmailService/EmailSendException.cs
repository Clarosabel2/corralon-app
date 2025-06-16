using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVC.EmailService
{
    public class EmailSendException : Exception
    {
        public EmailSendException() { }

        public EmailSendException(string message)
            : base(message) { }

        public EmailSendException(string message, Exception inner)
            : base(message, inner) { }
    }
}
