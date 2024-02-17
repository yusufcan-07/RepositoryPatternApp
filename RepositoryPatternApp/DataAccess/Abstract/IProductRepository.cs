using RepositoryPatternApp.Entity;

namespace RepositoryPatternApp.DataAccess.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
      

        //Special method for this interface
        Product[] GetProductsByCategory(int id);


    }
}