using System.Collections.Generic;
using System.Data;
using BDE;

namespace DAL
{
    public interface IProductRepository
    {
        void UpdateStockById(int idProduct, int amount);
        DataTable GetCateogyProducts();
        List<Product> GetAll();
        void DeleteProductById(int idProduct);
        void SaveProduct(Product p);
        Product GetProductById(int idprdt);
        bool UpdateProduct(Product p);
        string GetCategoryById(int idCategory);
    }
}
