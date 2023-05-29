using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_HW_1
{
    public class Result
    {
        public string Message { get; }

        public bool Status { get; }

        public Result(bool status, string message)
        {
        Status = status;
        Message = message;
        }
    }
}
