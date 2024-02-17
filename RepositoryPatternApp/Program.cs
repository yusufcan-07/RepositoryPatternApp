using System;
using RepositoryPatternApp.DataAccess.Abstract;
using RepositoryPatternApp.DataAccess.Concrete;
using RepositoryPatternApp.Entity;

namespace RepositoryPatternApp
{
    class ProductManager:IProductRepository
    {
        private IProductRepository _repository;
        public ProductManager(IProductRepository repository)
        {
            _repository = repository;

        }
        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Create(Product entity)
        {
            _repository.Create(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // var productDal = new EfProductDal();
            // var productDal = new MySQLProductDal();
            // productDal.Create(new Product());

            // var productDal = new ProductManager(new EfProductDal());
            var productDal = new ProductManager(new MySQLProductDal());
            productDal.Create(new Product());
            //Burada direkt olarak EfproductDal ve MySQLDal yazmayacağız
            //injection devreye girer : IProductRepository çağrıldığı zaman =>EfProductDal veya diğer Database teknolojisini içeren Concrete Class'ını getirecek. Uygulamada bir yerde tanımlama yapıp yukarıdaki gibi direkt yazmayacağız
        }
    }
}