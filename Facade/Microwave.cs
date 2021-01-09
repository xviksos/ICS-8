﻿namespace Lab7Facade
{
    internal class Microwave
    {
        // Класс Фасада. Фасад предоставляет быстрый доступ к определённой функциональности подсистемы. 
        // Он «знает», каким классам нужно переадресовать запрос, и какие данные для этого нужны.
        // Помимо основного Фасада может быть доп. фасад. Дополнительный фасад можно ввести, чтобы 
        // не «захламлять» единственный фасад разнородной функциональностью. Он может использоваться как клиентом, так и другими фасадами.

        // Прочие классы являются сложной подсистемой (в сумме). Сложная подсистема состоит из множества разнообразных классов. Для того, чтобы 
        // заставить их что-то делать, нужно знать подробности устройства подсистемы, порядок инициализации объектов и так далее.
        // Классы подсистемы не знают о существовании фасада и работают друг с другом напрямую.

        // Был добавлен метод Cook - представляющий собой фасад по рпиготовлению продуктов
        private readonly Drive _drive;
        private readonly Notification _notification;
        private readonly Power _power;

        public Microwave(Drive drive, Power power, Notification notification)
        {
            _drive = drive;
            _power = power;
            _notification = notification;
        }

        public void Defrost()
        {
            _notification.StartNotification();
            _power.MicrowavePower = 1000;
            _drive.TurnRight();
            _drive.TurnRight();
            _power.MicrowavePower = 500;
            _drive.Stop();
            _drive.TurnLeft();
            _drive.TurnLeft();
            _power.MicrowavePower = 200;
            _drive.Stop();
            _drive.TurnRight();
            _drive.TurnRight();
            _drive.Stop();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
        }
        
        public void Cook()
        {
            _notification.StartNotification();

            _power.MicrowavePower = 2000;
            _drive.TurnRight();
            _drive.TurnRight();
            _drive.Stop();
            _power.MicrowavePower = 1000;
            _drive.TurnLeft();
            _drive.TurnLeft();
            _drive.Stop();
            _power.MicrowavePower = 0;
            _notification.StopNotification();
        }
    }
}