using Microsoft.Office.Interop.Excel;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace RegexSearch
{
    class ExcelFile
    {
        public static int getExcelFile(string filePath, string regexPattern)
        {
            try
            {
                //Create COM Objects. Create a COM object for everything that is referenced
                Application xlApp = new Application();
                Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
                _Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;

                //iterate over the rows and columns and print to the console as it appears in the file
                //excel is not zero based!!
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        //new line
                        if (j == 1)
                            Console.Write("\r\n");

                        //write the value to the console
                        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        {
                            Console.Write(xlRange.Cells[i, j].Value2.ToString() + "\t");
                            if (Regex.IsMatch(xlRange.Cells[i, j].Value2.ToString(), regexPattern))
                            {
                                Console.ReadKey();

                                //release com objects to fully kill excel process from running in the background
                                Marshal.ReleaseComObject(xlRange);
                                Marshal.ReleaseComObject(xlWorksheet);

                                //close and release
                                xlWorkbook.Close();
                                Marshal.ReleaseComObject(xlWorkbook);

                                //quit and release
                                xlApp.Quit();
                                Marshal.ReleaseComObject(xlApp);

                                return 1;
                            }                            
                        }                            
                    }
                }
                
                //release com objects to fully kill excel process from running in the background
                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                //close and release
                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                //quit and release
                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            catch(Exception exc)
            {
                Console.WriteLine("The file could not be read: ");
                Console.WriteLine(exc.Message);
            }

            Console.ReadKey();
            return 0;
        }
    }
}
