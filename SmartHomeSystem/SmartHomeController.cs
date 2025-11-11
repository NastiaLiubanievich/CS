using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSystem
{
    public class SmartHomeController
    {
        public List<ISwitchable> devices = new List<ISwitchable>();
        public List<IEnergyConsumer> energyDevices = new List<IEnergyConsumer>();
        public void AddDevice(ISwitchable device)
        {
            devices.Add(device);
        }
        public void AddEnergyDevice(IEnergyConsumer device)
        {
            energyDevices.Add(device);
        }
        public void TurnAllOn()
        {
            foreach (ISwitchable device in devices)
            {
                device.TurnOn();
            }
        }
        public void TurnAllOff()
        {
            foreach (ISwitchable device in devices)
            {
                device.TurnOff();
            }
        }
        public void ShowEnergyReport(int hours)
        {
            Console.WriteLine($"Звіт про споживання енергії за {hours} год:");
            double total = 0;

            for (int i = 0; i < energyDevices.Count; i++)
            {

                IEnergyConsumer device = energyDevices[i];

                double energy = device.GetEnergyUsage(hours);
                total += energy;
                Console.WriteLine($"{device.DeviceName}: {energy:F2} кВт·год (потужність: {device.PowerConsumption} Вт)");
            }
            Console.WriteLine($"Загальне споживання: {total:F2} кВт·год");
            Console.WriteLine($"Вартість (~4 грн/кВт·год): {total * 4:F2} грн");
        }
    }
}
