using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Repository.Contract
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetItems();
        Task<IEnumerable<ProductCategory>> GetCategories();
        Task<Product> GetItem(int id);
        Task<ProductCategory> GetCategory(int id);
    }
}
