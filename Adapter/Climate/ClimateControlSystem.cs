namespace Lab1Adapter.Climate
{
    public class ClimateControlSystem
    // Класс-клиент, который содержит существующую бизнес-логику программы и 
    // имеет доступ к архитектуре адаптера через интерфейс
    {
        public ClimateControlSystem(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public double Run(ITemperatureSensor temperatureSensor)
        {
            return temperatureSensor.Measure();
        }
    }
}