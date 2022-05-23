using shopapp.entity;
using SHOPAPP.DATA.Abstract;
using System.Collections.Generic;

namespace SHOPAPP.DATA.Concrete.EfCore
{
    public class EfCoreCategoryRepository : ICategoryRepository
    {
        private ShopContext db = new ShopContext();
        public void Create(Category entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Category> GetPopularCategories()
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
