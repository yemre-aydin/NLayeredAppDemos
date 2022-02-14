using FluentValidation;
using NorthwindEntities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBusiness.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty();
            RuleFor(p=>p.CategoryId).NotEmpty();
            RuleFor(p=>p.UnitPrice).NotEmpty();
            RuleFor(p=>p.QuantityPerUnit).NotEmpty();
            RuleFor(p=>p.UnitInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0);
            //vs.... burada kuralları yazabiliriz
            //kendinde kural yazabilirsin
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Ürün adı A ile başlamalıdır.");
                                                        //burada tanımlı mesaj yerine bu kural uyulmadığında çıkacak mesaj yazılabilir.


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");//bunun gibi kendi kuralları da yazabiliriz
        }
    }
}
