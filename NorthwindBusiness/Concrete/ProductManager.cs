using NorthwindBusiness.Abstract;
using NorthwindDataAccess.Abstract;
using NorthwindDataAccess.Concrete;
using NorthwindDataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntities.Concrete
{
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        //EfProductDal productDal = new EfProductDal();//böyle bir hatalı bizi bağımlı yapar
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;  
        }

        public List<Product> GetAll()
        {

            //Business Code
            //iş kamanı iş kuralları buraya yazılır

            return _productDal.GetAll();

        }

        
    }
}
