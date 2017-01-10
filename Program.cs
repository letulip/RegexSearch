using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexSearch
{
    class Program
    {
        static string filePath;
        public static string regexPattern;

        static int Main(string[] args)
        {
            //Console.WriteLine("Введите путь к файлу, пожалуйста: ");
            //string filePath = Console.ReadLine();

            //проверка наличия входных данных
            if (args == null || args.Length < 2)
            {                
                return 0;
            }

            filePath = args[0];
            regexPattern = args[1];

            //проверка файла xlsx
            if (Path.GetExtension(filePath) == ".xlsx")
            {
                string[] input = ExcelFile.getExcelFile(filePath);

                return RegexChecking.RegexCheck(input);
            }

            //проверка файла txt
            if (Path.GetExtension(filePath) == ".txt")
            {string[] input = TextFile.getTextFile(filePath);

                return RegexChecking.RegexCheck(input);
            }
                
            return 0;
        }
    }
}
