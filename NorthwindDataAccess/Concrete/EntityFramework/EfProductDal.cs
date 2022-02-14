using NorthwindDataAccess.Abstract;
using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        //veritabanı ekle sil güncelle işlemlerini tekrar yazmak yerine EfEntityRepository den çağırıyoruz
        //burada bu kadar iş yapılır
        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
