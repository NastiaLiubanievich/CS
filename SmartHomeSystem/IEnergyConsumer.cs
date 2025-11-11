using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public interface IEnergyConsumer
    {
        string DeviceName { get; }
        int PowerConsumption { get; }
        bool IsOn { get; }
        public double GetEnergyUsage(int hours)
        {
            if (IsOn == false)
                return 0;
            return (PowerConsumption * hours) / 1000;
        }
    }
}
