using BDE;
using DAL;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class BLL_Product
    {
        static string appRoot = AppDomain.CurrentDomain.BaseDirectory;
        static string MediaRoot => Path.Combine(appRoot, "Media", "Products");
        static string ThumbsRoot => Path.Combine(MediaRoot, "thumbs");
        public static string GetMediaRoot() => MediaRoot;


        public static bool isLowStock = false;
        public static void DeleteProductById(int productId)
        {
            DAL_Product.DeleteProductById(productId);
        }

        public static DataTable GetCaterogyProducts()
        {
            return DAL_Product.GetCateogyProducts();
        }

        public static BE_Product GetProductById(int idprdt)
        {
            return DAL_Product.GetProductById(idprdt);
        }

        public static List<BE_Product> GetProducts()
        {
            List<BE_Product> products = DAL_Product.GetProducts().AsEnumerable()
                .Select(p => new BE_Product(p)).ToList();

            isLowStock = products.Any(p => p.Stock <= p.MinStock);
            return products;
        }

        public static void SaveProduct(BE_Product p)
        {
            p.ImagePath = SaveImgToRepository(p.ImagePath, BuildFileNameProduct(p));
            DAL_Product.SaveProduct(p);
        }

        public static string GetCategoryProductById(string idCategory)
        {
            if (string.IsNullOrWhiteSpace(idCategory))
                return null;
            if (!int.TryParse(idCategory, out int id))
                return null;
            return DAL_Product.GetCategoryById(id);
        }
        public static void UpdateProduct(BE_Product p, bool flag)      
        {
            if (flag)
            {
                p.ImagePath = SaveImgToRepository(p.ImagePath, BuildFileNameProduct(p));
            }
            DAL_Product.UpdateProduct(p);
        }
        public static void UpdateStockById(int idProduct, int quantity)
        {
            DAL_Product.UpdateStockById(idProduct, quantity);
        }

        private static string BuildFileNameProduct(BE_Product p)
        {
            return $"{San(p?.Name)}-{San(p?.Brand?.NameBrand)}-{San(GetCategoryProductById(p.Category))}".Trim('_');
        }

        private static string San(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "";
            var invalid = Path.GetInvalidFileNameChars();
            var cleaned = new string(s.Trim().Select(ch => invalid.Contains(ch) ? '_' : ch).ToArray())
                .Replace(' ', '_');
            while (cleaned.Contains("__")) cleaned = cleaned.Replace("__", "_");
            if (cleaned.Length > 80) cleaned = cleaned.Substring(0, 80);
            return cleaned;
        }

        private static string SaveImgToRepository(string imagePath, string fileName)
        {
            if (imagePath == null) throw new ArgumentNullException(nameof(imagePath));
            if (string.IsNullOrWhiteSpace(imagePath))
                throw new InvalidOperationException("El producto no tiene ruta de imagen.");

            string srcFull = Path.GetFullPath(imagePath);
            if (!File.Exists(srcFull))
                throw new FileNotFoundException("No existe el archivo de origen.", srcFull);

            string mediaRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Media", "Products");
            Directory.CreateDirectory(mediaRoot);

            string ext = Path.GetExtension(srcFull);
            if (string.IsNullOrWhiteSpace(ext)) ext = ".jpg";

            if (string.IsNullOrWhiteSpace(fileName)) fileName = "producto";

            string destName = fileName + ext.ToLowerInvariant();
            string destFull = Path.Combine(mediaRoot, destName);
        
            if (!string.Equals(srcFull, destFull, StringComparison.OrdinalIgnoreCase))
            {     
                File.Copy(srcFull, destFull, overwrite: true);
            }
            return $"Media/Products/{destName}";
        }
    }
}
