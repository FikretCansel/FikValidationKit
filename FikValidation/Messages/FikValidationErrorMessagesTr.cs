using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikValidation.FikValidation
{
    public class FikValidationErrorMessagesTr : IFikValidationErrorMessages
    {
        public string NotEquals => "Eşit Degil";

        public string GraterThan => "Daha büyük degil";

        public string NotEmpty => "Deger Boş";
    }
}
