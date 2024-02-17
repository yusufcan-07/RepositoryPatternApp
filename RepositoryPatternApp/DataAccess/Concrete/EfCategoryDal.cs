using RepositoryPatternApp.DataAccess.Abstract;
using RepositoryPatternApp.Entity;

namespace RepositoryPatternApp.DataAccess.Concrete
{
    //public class MySQLProductDat : ICategoryRepository when using a MySQL database instead of ORM (Entity Framework)
    public class EfCategoryDal:ICategoryRepository
    {
        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Category prod)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Category prod)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Category[] GetCategories()
        {
            throw new System.NotImplementedException();
        }
    }
}