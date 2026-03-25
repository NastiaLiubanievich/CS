using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul1
{
    public delegate string TextOperation(string line);

    public class TextProcessor
    {
        public static void ProcessFile(string inputPath, string outputPath, TextOperation operation)
        {
            var lines = File.ReadAllLines(inputPath);

            foreach (var line in lines)
            {
                string result = operation(line);
                File.AppendAllText(outputPath, result + Environment.NewLine);
            }

            File.AppendAllText(outputPath, "----" + Environment.NewLine);
        }
    }
}
