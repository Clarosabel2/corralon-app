using BDE;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public interface IProductService
    {
        bool IsLowStock { get; }
        string GetMediaRoot();
        void DeleteProductById(int productId);
        void SaveProduct(Product p, bool flag);
        void UpdateProduct(Product p, bool flag);
        void UpdateStockById(int idProduct, int quantity);
        DataTable GetCaterogyProducts();
        Product GetProductById(int idprdt);
        List<Product> GetProducts();
        
        string GetCategoryProductById(string idCategory);
    }
}
