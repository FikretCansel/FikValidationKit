using FikValidation.FikValidation.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikValidation.FikValidation
{
    public class ValidationManager:IValidationService
    {
        IFikValidationErrorMessages validationErrorMessages;

        public ValidationManager(IFikValidationErrorMessages fikValidationErrorMessagesTr)
        {
            validationErrorMessages = fikValidationErrorMessagesTr;
        }

        public FikEntity GraterThan(double x, double y)
        {
            if (x > y)
            {
                return new FikEntity(true); ;
            }
            return new FikEntity(false, validationErrorMessages.GraterThan);
        }

        public FikEntity IsEquals(object x,object y)
        {
            if (x.Equals(y))
            {
                return new FikEntity(true);
            }
            return new FikEntity(false, validationErrorMessages.NotEquals);
        }
        public FikEntity NotEmpty(string x)
        {
            Console.WriteLine(nameof(x));
            if (!x.Equals("") && x!=null)
            {
                return new FikEntity(true);
            }
            return new FikEntity(false, validationErrorMessages.NotEmpty);
        }

    }
}
