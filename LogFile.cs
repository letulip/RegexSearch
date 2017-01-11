using System;

namespace RegexSearch
{
    class LogFile
    {
        //запись сообщений в лог-файл
        public static void Write(string msg)
        {
            DateTime currtime = DateTime.Now;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"log.txt", true))
            {
                string logString = string.Format("{0:yy/MM/dd hh:mm:ss} : {1}", currtime, msg);
                file.WriteLine(logString);
                file.Close();
            }
        }
    }
}
