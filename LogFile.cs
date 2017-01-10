using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexSearch
{
    class LogFile
    {
        public static void Write(string msg)
        {
            DateTime currtime = DateTime.Now;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"log.txt", true))
            {
                string logString = string.Format("{0:yyMMdd hh:mm:ss} : {1}", currtime, msg);
                file.WriteLine(logString);
                file.Close();
            }
        }
    }
}
