using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    static class ExternalMethodsActivities
    {
        public static string UpperEvenLetter(this string s)
        {
            string TempS = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (i % 2 == 0) TempS += char.ToUpper(s[i]);
                else TempS += char.ToLower(s[i]);
            }

            return TempS;
        }
        
    }
}
