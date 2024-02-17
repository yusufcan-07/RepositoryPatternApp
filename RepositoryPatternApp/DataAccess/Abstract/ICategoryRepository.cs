using RepositoryPatternApp.Entity;

namespace RepositoryPatternApp.DataAccess.Abstract
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Category[] GetCategories();

    }
}