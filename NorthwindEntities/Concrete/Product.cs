using NorthwindEntities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NorthwindEntities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        [Required]//bu yöntem validation a arternatif bir yöntemdir fakat SOLID pronsibine aykırıdır.çok tercih edilmemeli
        public string ProductName { get; set; }

        public int CategoryId  { get; set; }
        public decimal UnitPrice { get; set; }

        public string QuantityPerUnit { get; set; }

        public Int16 UnitInStock { get; set; }
    }
}
