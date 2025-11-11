namespace SmartHomeSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SmartHomeController controller = new SmartHomeController();

            Light lamp = new Light();
            lamp.Name = "Лампа у вітальні";
            AirConditioner conditioner = new AirConditioner();
            conditioner.Name = "Кондиціонер у спальні";
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.Name = "Кавомашина на кухні";
            MotionSensor motionSensor = new MotionSensor();
            motionSensor.Name = "Датчик руху у коридорі";

            controller.AddDevice(lamp);
            controller.AddDevice(conditioner);
            controller.AddDevice(coffeeMachine);
            controller.AddDevice(motionSensor);
            
            controller.AddEnergyDevice(lamp);
            controller.AddEnergyDevice(conditioner);
            controller.AddEnergyDevice(coffeeMachine);

            controller.TurnAllOn();
            Console.WriteLine();

            lamp.PrintStatus();
            conditioner.PrintStatus();
            coffeeMachine.PrintStatus();
            motionSensor.PrintStatus();
            Console.WriteLine();

            controller.ShowEnergyReport(5);
            Console.WriteLine();

            controller.TurnAllOff();
        }
    }
}
