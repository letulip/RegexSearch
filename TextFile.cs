using System;
using System.IO;

namespace RegexSearch
{
    class TextFile
    {
        public static string[] getTextFile(string filepath)
        {
            try
            {
                string[] output = File.ReadAllLines(filepath);
                return output;
            }
            catch (Exception exc)
            {
                string[] output = new string[2];
                output[0] = "The file could not be read: ";
                output[1] = exc.Message;
                LogFile.Write(exc.Message);
                return output;
            }
        }
    }
}
