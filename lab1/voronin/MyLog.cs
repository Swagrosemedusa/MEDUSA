using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace voronin
{
    class MyLog : Core.LogAbstract<MyLog>, Core.LogInterface
    {
        static public void log(string s)
        {
            Instance()._log_v1(s);
        }

        public void _log_v1(string s)
        {
            _log.Add(s);
        }

        static public void write()
        {
            Instance()._write();
        }

         public override void _write()
         {
            for(int i=0;i<_log.Count;i++)
            {
                Console.WriteLine(_log[i]);
            }
        }
    }
}
