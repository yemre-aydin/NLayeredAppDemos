using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindDataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>//burası üçündü adım bir interface  dal sınıfı oluşturmak
    {
        
    }
}
