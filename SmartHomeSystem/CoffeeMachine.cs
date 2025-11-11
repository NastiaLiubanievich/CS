using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHomeSystem
{
    public class CoffeeMachine : Device, IEnergyConsumer
    {
        public string DeviceName => Name;
        public int PowerConsumption { get; } = 1000;
        public override void TurnOn()
        {
            IsOn = true;
            Console.WriteLine($"{Name} почала готувати каву.");
        }

        public override void TurnOff()
        {
            IsOn = false;
            Console.WriteLine($"{Name} завершила роботу.");
        }

        public double GetEnergyUsage(int hours)
        {
            if (IsOn == false)
                return 0;
            return (PowerConsumption * hours) / 1000.0;
        }
    }
}
