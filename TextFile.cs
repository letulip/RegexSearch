using System;
using System.IO;

namespace RegexSearch
{
    class TextFile
    {
        //обработка текстового файла
        public static string[] getTextFile(string filePath)
        {
            try
            {
                //запись данных из файла в массив строк output
                string[] output = File.ReadAllLines(filePath);
                return output;
            }
            catch (Exception exc)
            {
                string[] output = new string[2];
                output[0] = "Файл не может быть прочитан: ";
                output[1] = exc.Message;
                LogFile.Write(exc.Message);
                return output;
            }
        }
    }
}
