using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2
{
    public class FileLogger
    {
        private string filePath;
        public FileLogger(string path)
        {
            filePath = path;
        }
        public void OnMessageSent(string message)
        {
            string log = $"{DateTime.Now}: {message}";
            File.AppendAllText(filePath, log + Environment.NewLine);
        }
    }
}
