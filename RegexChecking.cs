using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexSearch
{
    public static class RegexChecking
    {        
        public static int RegexCheck(string[] input)
        {
            if (input == null)
            {
                LogFile.Write("Получен пустой файл");
                return 0;
            }

            foreach (string str in input)
            {
                if (Regex.IsMatch(str, Program.regexPattern))
                {
                    LogFile.Write("Совпадение с регулярным выражением найдено");
                    return 1;
                }
            }
            LogFile.Write("Совпадение с регулярным выражением не найдено");
            return 0;
        }
    }
}
