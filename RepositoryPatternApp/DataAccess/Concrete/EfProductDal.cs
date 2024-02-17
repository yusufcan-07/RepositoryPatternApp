using System;
using RepositoryPatternApp.DataAccess.Abstract;
using RepositoryPatternApp.Entity;

namespace RepositoryPatternApp.DataAccess.Concrete
{
    public class EfProductDal:IProductRepository
    {
        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product prod)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Product prod)
        {
            Console.WriteLine("EFProduct - created!");
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}