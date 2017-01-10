using System;
using System.IO;

namespace RegexSearch
{
    class TextFile
    {
        public static int getTextFile(string filepath, string regexPattern)
        {
            try
            {
                return RegexChecking.RegexCheck(File.ReadAllLines(filepath), regexPattern);
            }
            catch (Exception exc)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(exc.Message);
                LogFile.Write(exc.Message);
                return 0;
            }
        }
    }
}
