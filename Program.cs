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

            string textPattern = @"\.txt";
            string xlsxPattern = @"\.xlsx";
            
            
            

            try
            {   
                using (StreamReader sr = new StreamReader(filePath))
                {                    
                    String line = sr.ReadToEnd();
                    Console.WriteLine(line);

                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(e.Message);

                Console.ReadKey();
            }
        }
    }
}
