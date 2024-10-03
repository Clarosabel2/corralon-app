using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDE
{
    public abstract class BE_Permission
    {
        public string Id { get; set; }
        public string Description { get; set; }

        public BE_Permission(string id, string description)
        {
            Id = id;
            Description = description;
            
        }

        public abstract IList<BE_Permission> Children { get; }
        public abstract void addChild(BE_Permission c);
        public abstract void removeChild(BE_Permission c);
        
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
