using System;

namespace Lab7Facade
{
    internal class Program
    {
        // Фасад — это структурный паттерн проектирования, который предоставляет простой интерфейс к сложной системе классов, библиотеке или фреймворку.
        // По факту этот класс - Клиент. Клиент использует фасад вместо прямой работы с объектами сложной подсистемы.
        private static void Main(string[] args)
        {
            var drive = new Drive();
            var power = new Power();
            var notification = new Notification();
            var microwave = new Microwave(drive, power, notification);

            power.PowerEvent += PowerPowerEvent;
            drive.DriveEvent += DriveDriveEvent;
            notification.notificationEvent += NotificationNotificationEvent;

            Console.WriteLine("Defrost");
            microwave.Defrost();
            //вызов нового фасада
            Console.WriteLine("Cooking:");
            microwave.Cook();
        }

        private static void NotificationNotificationEvent(object sender, EventArgs e)
        {
            var n = (Notification) sender;
            Console.WriteLine(n.ToString());
        }

        private static void DriveDriveEvent(object sender, EventArgs e)
        {
            var d = (Drive) sender;
            Console.WriteLine(d.ToString());
        }

        private static void PowerPowerEvent(object sender, EventArgs e)
        {
            var p = (Power) sender;
            Console.WriteLine(p.ToString());
        }
    }
}