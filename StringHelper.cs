using System;
using System.Text.RegularExpressions;

namespace PadawansTask4
{
    public class StringHelper
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;
            if (str == "")
                throw new ArgumentException();
            if (str == null)
                throw new ArgumentNullException();
            Regex vowels = new Regex(@"[aeiou]");
            MatchCollection matches = vowels.Matches(str);
            foreach(Match match in matches)
            {
                vowelCount++;
            }
            return vowelCount;
        }
    }
}
