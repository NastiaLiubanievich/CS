using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public interface ISwitchable
    {
        void TurnOn()
        {
            Console.WriteLine("Пристрій ввімкнений");
        }
        void TurnOff()
        {
            Console.WriteLine("Пристрій вимкнений");
        }
        public bool IsOn { get; }
    }
}
