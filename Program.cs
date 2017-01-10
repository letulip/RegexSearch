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

            if (args == null || args.Length < 2)
            {                
                return 0;
            }

            filePath = args[0];
            regexPattern = args[1];

            if (Path.GetExtension(filePath) == ".xlsx")
            {
                return ExcelFile.getExcelFile(filePath, regexPattern);

                //Console.ReadKey();
                //return 1;
            }

            if (Path.GetExtension(filePath) == ".txt")
            {
                //TextFile.getTextFile(filePath);

                string[] partNumbers = File.ReadAllLines(filePath);

                //string pattern = @"^[a-zA-Z0-9]\d{2}[a-zA-Z0-9](-\d{3}){2}[A-Za-z0-9]";
                
                foreach (string partNumber in partNumbers)
                {
                    Console.WriteLine("{0} {1} a valid part number.", partNumber, Regex.IsMatch(partNumber, regexPattern) ? "is" : "is not");

                    if (Regex.IsMatch(partNumber, regexPattern))
                    {
                        Console.ReadKey();
                        return 1;
                    }                        
                }
            }
                
            return 0;
        }
    }
}
