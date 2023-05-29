using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Module_2_HW_1
{
    class Logger
    {
        private const int DataSize = 200;
        private string[] _data = new string[DataSize];
        private int _dataIndex = 0;

        private static Logger _instance;

        public static Logger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }

                return _instance;
            }
        }

        public void Log(LogType type, string message)
        {
            var log = $"{DateTime.Now.ToLongTimeString()} : {type} : {message}";
            if (_dataIndex < DataSize)
            {
                _data[_dataIndex] = log;
                _dataIndex++;
            }

            Console.WriteLine(log);
        }

        public string[] GetData()
        {
            return _data;
        }
    }
}
