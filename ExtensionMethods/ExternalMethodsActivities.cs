using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class ExternalMethodsActivities
    {
        private static string _Temp = "";
        public static string UpperEvenLetter(this string s)
        {
            
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0) _Temp += char.ToUpper(s[i]);
                else _Temp += char.ToLower(s[i]);
            }
            return _Temp;
        }
        public static string UpperFirstLetter(this string s)
        {
            return char.ToUpper(s[0]) + s.Substring(1).ToLower();
        }
        
    }
}
