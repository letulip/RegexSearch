using Microsoft.Office.Interop.Excel;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace RegexSearch
{
    class ExcelFile
    {
        public static string[] getExcelFile(string filePath)
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
                        {
                            string[] output = new string[1];
                            output[1] = "\r\n";
                            return output;
                        }

                        //write the value to the console
                        if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        {
                            return xlRange.Cells[i, j].Value2.ToString() + "\t";
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
            catch (Exception exc)
            {
                string[] output = new string[2];
                output[0] = "The file could not be read: ";
                output[1] = exc.Message;
                LogFile.Write(exc.Message);
                return output;
            }
        }
    }
}
