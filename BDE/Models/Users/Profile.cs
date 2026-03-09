using BDE.Permissions;
using System.Collections.Generic;

namespace BDE
{
    public  class Profile
    {
        private int id;
        private string name;
        private List<BE_Permission> permissions;

        public Profile()
        {

        }
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public List<BE_Permission> Permissions { get => permissions; set => permissions = value; }
    }
}