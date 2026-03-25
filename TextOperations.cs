using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{

    public class TextOperations
    {
        public static string ToUpperCase(string line)
        {
            return line.ToUpper();
        }
        public static string CountChars(string line)
        {
            return $"{line} | {line.Length}";
        }
        public static string CountWords(string line)
        {
            int wordCount = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
            return $"{line} | Words: {wordCount}";
        }
    }
}
