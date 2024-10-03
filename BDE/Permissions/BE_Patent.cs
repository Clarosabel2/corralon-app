using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE.Composite
{
    public class BE_Patent : BE_Permission
    {
        public BE_Patent(string id, string description) : base(id, description)
        {
        }

        public override IList<BE_Permission> Children
        {
            get
            {
                return new List<BE_Permission>();
            }
        }

        public override void addChild(BE_Permission c)
        {
            throw new NotImplementedException();
        }

        public override void removeChild(BE_Permission c)
        {
            throw new NotImplementedException();
        }
    }
}
