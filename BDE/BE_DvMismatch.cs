using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public enum DvKind
    {
        DVH,
        DVV
    }
    public enum DvErrorKind {
        MISSING_HASH,
        DIFF_HASH,
        ORPHAN_HASH
    }
    public sealed class DvMismatch
    {
        public string TableName { get; set; }
        public string RowKey { get; set; }
        public DvErrorKind KindError { get; set; }
        public DvKind DvKind { get; set; }

        public DvMismatch(string tableName, string rowKey, DvErrorKind kindError, DvKind dvKind)
        {
            TableName = tableName;
            RowKey = rowKey;
            KindError = kindError;
            this.DvKind = dvKind;
        }
    }
}
