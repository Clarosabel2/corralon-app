using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace BDE
{
    public class BE_Administrador : BE_Empleado
    {
        public BE_Administrador(int id, int dni, string nombre, string apellido, string domicilio, string email, int telefono, string area, double salario, string username, string password) 
            : base(id, dni, nombre, apellido, domicilio, email, telefono, area, salario, username, password)
        {

        }
    }
}
