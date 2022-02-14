using NorthwindDataAccess.Abstract;
using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
       

        

        
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    ProductId=1,
                    CategoryId=1,
                    ProductName="Laptop",
                    QuantityPerUnit="1 in box",
                    UnitPrice=3000,
                    UnitInStock=11
                }
            };
            return products;
        }

        public Product Get(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
