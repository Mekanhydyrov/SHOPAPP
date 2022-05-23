using shopapp.entity;
using System.Collections.Generic;

namespace SHOPAPP.DATA.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetPopularProducts();
        List<Product> GetTop5Products();
    }
}
