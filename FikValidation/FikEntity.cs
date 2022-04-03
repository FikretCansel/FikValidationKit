using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FikValidation.FikValidation
{
    public class FikEntity
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public FikEntity(bool _IsSuccess):base()
        {
            IsSuccess = _IsSuccess;
        }
        public FikEntity(bool _IsSuccess,String _Message)
        {
            IsSuccess = _IsSuccess;
            Message = _Message;
        }

    }
}
