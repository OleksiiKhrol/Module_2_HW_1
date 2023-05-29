using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_HW_1
{
    public class Actions
    {
        public Result MethodInfo()
        {
            var message = "Start method: MethodInfo";
            Logger.Instance.Log(LogType.Info, message);
            return new Result(true, message);
        }

        public Result MethodSkip()
        {
            var message = "Skipped logic in method: MethodSkip";
            Logger.Instance.Log(LogType.Warning, message);
            return new Result(true, message);
        }

        public Result MethodBroke()
        {
            var message = "I broke a logic";
            Logger.Instance.Log(LogType.Error, message);
            return new Result(false, message);
        }
    }
}
