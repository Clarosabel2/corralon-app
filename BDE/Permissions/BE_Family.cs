using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE.Composite
{
    public class BE_Family : BE_Permission
    {
        private IList<BE_Permission> _childs;

        public BE_Family(string id, string description) : base(id, description)
        {
            _childs = new List<BE_Permission>();
        }

        public override IList<BE_Permission> Children
        {
            get { return _childs.ToArray(); }
        }

        public override void addChild(BE_Permission c)
        {
            _childs.Add(c);
        }

        public override void removeChild(BE_Permission c)
        {
            _childs.Remove(c);
        }
    }
}
