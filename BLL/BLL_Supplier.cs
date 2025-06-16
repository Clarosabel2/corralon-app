using BDE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Supplier
    {
        public static List<BE_Supplier> GetAllSuppliers()
        {
            DataTable dt = DAL_Supplier.GetAllSuppliers();
            List<BE_Supplier> suppliers = new List<BE_Supplier>();
            foreach (DataRow row in dt.Rows)
            {
                BE_Supplier supplier = new BE_Supplier
                {
                    Id = Convert.ToInt32(row["id_proveedor"]),
                    Name = row["nombre"].ToString(),
                    ContactName = row["nombre_contacto"].ToString(),
                    ContactEmail = row["email"].ToString(),
                    Address = row["domicilio"].ToString(),
                    ContactPhone = row["telefono"].ToString()
                };
                supplier.BrandsAssociated = BLL_Brand.GetBrandsBySupplierId(supplier.Id);
                suppliers.Add(supplier);
            }

            return suppliers;
        }

        public static bool RegisterSupplier(BE_Supplier newSup)
        {
            if (DAL_Supplier.RegisterSupplier(newSup))
            {
                BLL_EventLog.LogEvent("Register a new Supplier",
                    BE_EventType.CREATE_SUPPLIER,
                    BDE.Enums.BE_ActivityLevel.SUCCESS);
                return true;
            }
            return false;
        }
    }
}
