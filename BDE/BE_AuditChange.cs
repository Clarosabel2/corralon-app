using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public class BE_AuditChange
    {
        public int AuditID { get; set; }
        public string TableName { get; set; } = "";
        public string ColumnName { get; set; } = "";
        public string Operation
        {
            get;
            set;
        } = "";
        public string RowKey { get; set; } = "";
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime ChangeDate { get; set; }
        public string ChangedBy { get; set; }
    }
}
