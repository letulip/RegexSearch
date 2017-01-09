using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexSearch
{
    class TextFile
    {
        public static void getTextFile(string filepath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(exc.Message);
            }
        }
    }
}
