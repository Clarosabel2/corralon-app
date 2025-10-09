using BDE;
using DAL;
using SVC;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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

            isLowStock = products.Any(p => p.Stock <= 20);
            return products;
        }

        public static void SaveProduct(BE_Product p)
        {
            if (p == null) throw new ArgumentNullException(nameof(p));
            if (string.IsNullOrWhiteSpace(p.ImagePath))
                throw new InvalidOperationException("El producto no tiene ruta de imagen.");

            // origen absoluto
            string srcFull = Path.GetFullPath(p.ImagePath);
            if (!File.Exists(srcFull))
                throw new FileNotFoundException("No existe el archivo de origen.", srcFull);

            // destino: <exe>\Media\Products
            string mediaRoot = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Media", "Products");
            Directory.CreateDirectory(mediaRoot);

            // extensión del origen
            string ext = Path.GetExtension(srcFull);
            if (string.IsNullOrWhiteSpace(ext)) ext = ".jpg";

            // nombre final: {Name}_{Brand}_{Category} + ext (sanitizado)
            string cat = p?.Category?.ToString();
            string baseName = $"{San(p?.Name)}_{San(p?.Brand?.NameBrand)}_{San(cat)}".Trim('_');
            if (string.IsNullOrWhiteSpace(baseName)) baseName = "producto";

            string destName = baseName + ext.ToLowerInvariant();
            string destFull = Path.Combine(mediaRoot, destName);

            // si origen y destino son el mismo archivo, no copies
            if (!string.Equals(srcFull, destFull, StringComparison.OrdinalIgnoreCase))
            {
                // ⬇️ sobrescribe si ya existe
                File.Copy(srcFull, destFull, overwrite: true);
            }

            // guarda la ruta RELATIVA para la BD
            p.ImagePath = $"Media/Products/{destName}";

            // DAL_Product.SaveProduct(p);
        }
        public static void UpdateProduct(BE_Product p)      
        {
            DAL_Product.UpdateProduct(p);
        }
        public static void UpdateStockById(int idProduct, int quantity)
        {
            DAL_Product.UpdateStockById(idProduct, quantity);
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
    }
}
