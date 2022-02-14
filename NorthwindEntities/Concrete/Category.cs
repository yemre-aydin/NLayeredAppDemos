using NorthwindEntities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindEntities.Concrete
{
    public class Category:IEntity
    {//burası ilk adım
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }


    }
}
