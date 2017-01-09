using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexSearch
{
    class Program
    {
        static int Main(string[] args)
        {
            //Console.WriteLine("Введите путь к файлу, пожалуйста: ");
            //string filePath = Console.ReadLine();

            if (args == null || args.Length == 0)
            {
                Console.WriteLine("Please specify arguments!");
                return 0;
            }
            else
            {
                if (Path.GetExtension(args[0]) == ".xlsx")
                {
                    ExcelFile.getExcelFile(args[0]);
                }
                if (Path.GetExtension(args[0]) == ".txt")
                {
                    TextFile.getTextFile(args[0]);
                }
                return 1;
            }
        }
    }
}
