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
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        static string appRoot = AppDomain.CurrentDomain.BaseDirectory;
        static string MediaRoot => Path.Combine(appRoot, "Media", "Products");
        static string ThumbsRoot => Path.Combine(MediaRoot, "thumbs");
        public string GetMediaRoot() => MediaRoot;


        private bool isLowStock = false;
        public bool IsLowStock => isLowStock;

        public void DeleteProductById(int productId)
        {
            _productRepository.DeleteProductById(productId);
        }

        public DataTable GetCaterogyProducts()
        {
            return _productRepository.GetCateogyProducts();
        }

        public Product GetProductById(int idprdt)
        {
            return _productRepository.GetProductById(idprdt);
        }

        public List<Product> GetProducts()
        {
            List<Product> products = _productRepository.GetAll();

            isLowStock = products.Any(p => p.Stock <= p.MinStock);
            return products;
        }


        public string GetCategoryProductById(string idCategory)
        {
            if (string.IsNullOrWhiteSpace(idCategory))
                return null;
            if (!int.TryParse(idCategory, out int id))
                return null;
            return _productRepository.GetCategoryById(id);
        }
        public void SaveProduct(Product p, bool flag)
        {
            if (flag)
            {
                p.ImagePath = SaveImgToRepository(p.ImagePath, BuildFileNameProduct(p));
            }
            _productRepository.SaveProduct(p);
            //BLL_DV_DB.RecalculateDV();
        }
        public void UpdateProduct(Product p, bool flag)      
        {
            if (flag)
            {
                p.ImagePath = SaveImgToRepository(p.ImagePath, BuildFileNameProduct(p));
            }
            if (_productRepository.UpdateProduct(p))
            {
                //BLL_DV_DB.RecalculateDV();
            }
        }
        public void UpdateStockById(int idProduct, int quantity)
        {
            _productRepository.UpdateStockById(idProduct, quantity);
        }

        private string BuildFileNameProduct(Product p)
        {
            return $"{San(p?.Name)}-{San(p?.Brand?.NameBrand)}-{San(GetCategoryProductById(p.Category))}".Trim('_');
        }

        private string San(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return "";
            var invalid = Path.GetInvalidFileNameChars();
            var cleaned = new string(s.Trim().Select(ch => invalid.Contains(ch) ? '_' : ch).ToArray())
                .Replace(' ', '_');
            while (cleaned.Contains("__")) cleaned = cleaned.Replace("__", "_");
            if (cleaned.Length > 80) cleaned = cleaned.Substring(0, 80);
            return cleaned;
        }

        private string SaveImgToRepository(string imagePath, string fileName)
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

        public List<Product> GetProductsBySaleId(int saleId)
        {
            //return _productRepository.GetBySaleId();
            return null;
        }
    }
}
