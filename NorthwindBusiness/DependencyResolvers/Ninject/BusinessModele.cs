using Ninject.Modules;
using NorthwindBusiness.Abstract;
using NorthwindBusiness.Concrete;
using NorthwindDataAccess.Abstract;
using NorthwindDataAccess.Concrete.EntityFramework;
using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBusiness.DependencyResolvers.Ninject
{
    public class BusinessModele : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();//bir kere üretmesi için InSinfletonScope kullanılabilir.
            Bind<IProductDal>().To<EfProductDal>();//IProductDal isterse EfProductDal ver demek
            
            Bind<ICategoryService>().To<CategoryManager>();
            Bind<ICategoryDal>().To<EfCategoryDal>();



        }
    }
}
