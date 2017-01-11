using System.Text.RegularExpressions;

namespace RegexSearch
{
    public static class RegexChecking
    {
        //проверка файла на совпадение с регулярным выражением 
        public static int RegexCheck(string[] input, string regexPattern)
        {
            if (input == null)
            {
                LogFile.Write("Получен пустой файл");
                return 0;
            }

            foreach (string str in input)
            {
                if (Regex.IsMatch(str, regexPattern))
                {
                    LogFile.Write("Совпадение с регулярным выражением найдено");
                    return 1;
                }
            }
            LogFile.Write("Совпадений с регулярным выражением не найдено");
            return 0;
        }
    }
}
