using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPattern.Singleton
{
    public class Logger
    {
        private static Logger? _instance = null;
        private static readonly object _instanceLock = new object();
        public int Count;

        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new Logger();
                        _instance.Count++;
                    }
                }

            }
            return _instance;
        }
    }
}
