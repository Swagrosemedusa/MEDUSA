using System;
using System.Collections.Generic;
using System.IO;
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

        override public void _write()
        {
            string date = DateTime.Now.ToString("dd.MM.yyyy_HH_mm_ss");
            for (int i = 0; i < _log.Count; i++)
            {
                Console.WriteLine(_log[i]);
            }
            string datename = @"Log\" + date + ".log";


            using (StreamWriter sw = new StreamWriter(datename, false, System.Text.Encoding.Default))
            {
                for (int i = 0; i < _log.Count; i++)
                {
                    sw.WriteLine(_log[i]);
                }
            }
        }
    }
}
