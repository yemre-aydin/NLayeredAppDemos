using NorthwindDataAccess.Abstract;
using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
       

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
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
    }
}
