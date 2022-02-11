﻿using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataAccess.Concrete
{
    public class ProductDal
    {
        //veritabanı ekle sil güncelle işlemlerini burada yapıyoruz.
        //burada bu kadar iş yapılır
        public List<Product> GetAll()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList();

            }

        }

        public Product Get(int id)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);

            }

        }

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();

            }

        }
        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {

                
                //context.Products.Update(product);
                context.SaveChanges();

            }

        }
        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //context.Products.Delete(product);
                context.SaveChanges();

            }

        }

    }
}
