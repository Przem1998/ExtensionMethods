using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public static string DeleteVowels(this string s)
        {
            return Regex.Replace(s, "[aeyioąęuóAEYIOĄĘUÓ]", "");
        }
        public static int CountWordsInString(this string s)
        {
            var words = s.Split(' ');
            int w = 0;
            foreach (string ws in words)
            {
                if (IsWord(ws)) w++;
            }
            return w;
        }
        private static bool IsWord(string s)
        {
            int l = 0; //count  leters/punctuation chars
            int p = 0; //count points 
            int tempIndex = 0; //use to compare with index in array to aims check countains multpoint
            char[] punctuations = { '.', '-', ',', '!', '?', ';' };
            char[] brackets = { '(', '[', '"' };
            if (s.Length == 1)
            {
                char c = s[0];
                if ((c >= 65 && c <= 90) || (c >= 97 && c <= 122)) return true;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 65 && s[i] <= 90) || (s[i] >= 97 && s[i] <= 122))
                {
                    l++;
                    if (l == s.Length - 1) return true;
                }
                else
                {
                    if (l == s.Length - 1)
                    {
                        if (s[i].ToString().Contains(s[i])) return true;
                    }
                    else if (s[i] == 46 && l > 0)
                    {
                        if (p == 0)
                        {
                            p++;
                            tempIndex = i;
                        }
                        else if (i - tempIndex == 1)
                        {
                            p++;
                            tempIndex = i;
                            if (p == 3) return true;
                        }

                        else return false;
                    }
                    else
                        return false;
                }
            }
            return false;
        }

    
    }
}
}
