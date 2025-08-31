using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Form
    {
        public static bool IsFormExist(string formName)
        {
            if (string.IsNullOrEmpty(formName))
                throw new ArgumentException("Form name cannot be null or empty.", nameof(formName));
            return DAL_Form.IsFormExist(formName);
            
        }
    }
}
