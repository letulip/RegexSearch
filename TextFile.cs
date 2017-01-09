using System;
using System.IO;

namespace RegexSearch
{
    class TextFile
    {
        public static void getTextFile(string filepath)
        {
            try
            {
                string[] partNumbers = File.ReadAllLines(filepath);
                //using (StreamReader sr = new StreamReader(filepath))
                //{
                //    String line = sr.ReadToEnd();
                //    Console.WriteLine(line);
                //}
            }
            catch (Exception exc)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(exc.Message);
            }
        }
    }
}
