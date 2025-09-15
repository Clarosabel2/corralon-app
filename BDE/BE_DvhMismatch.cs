using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public sealed class DvhMismatch
    {
        public string TableName { get; set; }
        public string RowKey { get; set; }
        public string Kind { get; set; }

        public DvhMismatch(string tableName, string rowKey, string kind)
        {
            TableName = tableName;
            RowKey = rowKey;
            Kind = kind;
        }
    }
}
