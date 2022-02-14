using FluentValidation;
using NorthwindBusiness.Abstract;
using NorthwindBusiness.ValidationRules.FluentValidation;
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

        public List<Product> GetProductsByCategory(int categoryId)
        {
            return _productDal.GetAll(p=>p.CategoryId == categoryId);
        }

        public List<Product> GetProductsByProductName(string productName)
        {
            return _productDal.GetAll(P=>P.ProductName.ToLower().Contains(productName.ToLower()));
        }
        public void Add(Product product)
        {
            ProductValidator productValidator=new ProductValidator();
            var result=productValidator.Validate(product);
            if (result.Errors.Count>0)
            {
                throw new ValidationException(result.Errors);//eğer hata varsa exception fırlat demiş oluyoruz
            }

            _productDal.Add(product);//bu şekilde koyduğumuz iş kurallarını programa dahil edebiliriz
        }
    }
}
