using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikValidation.FikValidation
{
    public interface IValidationService
    {
        FikEntity GraterThan(double x, double y);

        FikEntity IsEquals(object x, object y);

        FikEntity NotEmpty(string x);

    }
}
