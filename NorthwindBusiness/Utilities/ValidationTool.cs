using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBusiness.Utilities
{
    public class ValidationTool
    {
        //sıklıkla kullnacağımız validation metotlarını burada yazıp diğer classlarda kullanabiliriz


        public ValidationTool(IValidator validator,object entity)
        {
            var result = validator.Validate((IValidationContext)entity);
            if (result.Errors.Count > 0)
            {
                throw new InvalidOperationException(result.Errors.ToString());
            }

        }

    }
}
