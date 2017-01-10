using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexSearch
{
    class Program
    {
        static string filePath;
        static string regexPattern;

        static int Main(string[] args)
        {
            //Console.WriteLine("Введите путь к файлу, пожалуйста: ");
            //string filePath = Console.ReadLine();

            LogFile.Write("Программа запущена");

            //проверка наличия входных данных
            if (args == null || args.Length < 2)
            {
                LogFile.Write("Недостаточно входных данных");
                return 0;
            }

            LogFile.Write("Входных данные получены");
            filePath = args[0];
            regexPattern = args[1];

            //проверка файла xlsx
            if (Path.GetExtension(filePath) == ".xlsx")
            {
                LogFile.Write("Входный файл - xlsx");
                string[] input = ExcelFile.getExcelFile(filePath);

                return RegexChecking.RegexCheck(input, regexPattern);
            }

            //проверка файла txt
            if (Path.GetExtension(filePath) == ".txt")
            {
                LogFile.Write("Входной файл - txt");
                string[] input = TextFile.getTextFile(filePath);

                return RegexChecking.RegexCheck(input, regexPattern);
            }
                
            return 0;
        }
    }
}
