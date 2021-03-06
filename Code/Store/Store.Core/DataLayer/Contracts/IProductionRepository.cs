using System.Linq;
using System.Threading.Tasks;
using Store.Core.EntityLayer.Production;

namespace Store.Core.DataLayer.Contracts
{
    public interface IProductionRepository : IRepository
    {
        IQueryable<Product> GetProducts(int? productCategoryID = null);

        Task<Product> GetProductAsync(Product entity);

        Product GetProductByName(string  productName);

        IQueryable<ProductCategory> GetProductCategories();

        ProductCategory GetProductCategory(ProductCategory entity);

        IQueryable<ProductInventory> GetProductInventories(int? productID = null, string  warehouseID = null);

        ProductInventory GetProductInventory(ProductInventory entity);

        IQueryable<Warehouse> GetWarehouses();

        Task<Warehouse> GetWarehouseAsync(Warehouse entity);
    }
}
