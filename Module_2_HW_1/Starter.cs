using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_HW_1
{
    public class Starter
    {
        public void Run()
        {
            var actions = new Actions();
            for (int i = 0; i < 100; i++)
            {
                var choiseMet = new Random().Next(0, 3);
                Result result = null;

                if (choiseMet == 0)
                {
                    result = actions.MethodInfo();
                }
                else if (choiseMet == 1)
                {
                    result = actions.MethodSkip();
                }
                else
                {
                    result = actions.MethodBroke();
                }

                if (result != null && !result.Status)
                {
                    Logger.Instance.Log(LogType.Error, $"Action failed by а reason: " + result.Message);
                }
            }

            string[] data = Logger.Instance.GetData();
            string filePath = "log.txt";
            string fileData = string.Join(Environment.NewLine, data);

            File.WriteAllText(filePath, fileData);
        }
    }
}
