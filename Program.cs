using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace RegexSearch
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу, пожалуйста: ");
            string filePath = Console.ReadLine();

            if(Path.GetExtension(filePath) == ".xlsx")
            {
                ExcelFile.getExcelFile(filePath);
            }
            if(Path.GetExtension(filePath) == ".txt")
            {
                TextFile.getTextFile(filePath);
            }
            

            Console.ReadKey();
        }
    }
}
