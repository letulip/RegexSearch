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
                return 0;
            }

            foreach (string str in input)
            {
                if (Regex.IsMatch(str, Program.regexPattern))
                {
                    return 1;
                }
            }
            return 0;
        }
    }
}
