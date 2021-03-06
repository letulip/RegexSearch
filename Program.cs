﻿using System;
using System.IO;

namespace RegexSearch
{
    class Program
    {
        static string filePath;
        static string regexPattern;
        static string[] input;

        static int Main(string[] args)
        {
            //возможность ввода пути к файлу вручную в окне консоли
            //Console.WriteLine("Введите путь к файлу, пожалуйста: ");
            //string filePath = Console.ReadLine();

            //возможность ввода регулярного выражения вручную в окне консоли
            //Console.WriteLine("Введите регулярное выражение, пожалуйста: ");
            //string regexPattern = Console.ReadLine();

            LogFile.Write("Программа запущена");

            //проверка наличия входных данных
            if (args == null || args.Length < 2)
            {
                LogFile.Write("Недостаточно входных данных");
                return 0;
            }

            LogFile.Write("Входные данные получены");
            filePath = args[0];
            regexPattern = args[1];

            //проверка файла xlsx
            if (Path.GetExtension(filePath) == ".xlsx")
            {
                LogFile.Write("Входный файл - xlsx");
                input = ExcelFile.getExcelFile(filePath);
            }

            //проверка файла txt
            if (Path.GetExtension(filePath) == ".txt")
            {
                LogFile.Write("Входной файл - txt");
                input = TextFile.getTextFile(filePath);
            }

            return RegexChecking.RegexCheck(input, regexPattern);
            
        }
    }
}
