﻿using OfficeOpenXml;
using System;
using System.IO;

namespace RegexSearch
{
    class ExcelFile
    {
        //обработка excel файла
        public static string[] getExcelFile(string filePath)
        {
            try
            {
                //открыть файл
                var package = new ExcelPackage(new FileInfo(filePath));

                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

                string[] output = new string[workSheet.Dimension.End.Column * workSheet.Dimension.End.Row];
                int k = 0;

                //запись данных из файла в массив строк output
                for (int i = workSheet.Dimension.Start.Column;
                i <= workSheet.Dimension.End.Column;
                i++)
                {
                    for (int j = workSheet.Dimension.Start.Row;
                    j <= workSheet.Dimension.End.Row;
                    j++)
                    {
                        output[k] = workSheet.Cells[j, i].Value.ToString();
                        k++;
                    }
                }

                //закрыть файл
                package.Dispose();
                
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
