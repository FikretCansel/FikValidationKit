using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikValidation.FikValidation.Messages
{
    public class FikValidationErrorMessagesEn : IFikValidationErrorMessages
    {
        public string NotEquals => "Not Equals";

        public string GraterThan => "Grater Than";

        public string NotEmpty => "Value Empty";
    }
}
