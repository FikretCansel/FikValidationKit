using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikValidation.FikValidation
{
    public class Validation
    {
        public static FikEntity Validate(params FikEntity[] validationService)
        {
           foreach (var va in validationService)
           {
              if (!va.IsSuccess)
              {
                return va;
              }
           }
           return new FikEntity(true);
        }
    }
}
