using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikValidation.FikValidation
{
    public interface IFikValidationErrorMessages
    {
        string NotEquals { get; }
        string GraterThan { get; }
        string NotEmpty { get; }
    }
}
