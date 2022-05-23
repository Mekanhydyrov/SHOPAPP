using shopapp.entity;
using System.Collections.Generic;

namespace SHOPAPP.DATA.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}
