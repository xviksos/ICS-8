using System;

namespace Lab1Adapter.Climate
{
    public class TemperatureSensorAdapter : ITemperatureSensor
    // Реализует клиентский интерфейс и содержит ссылку на объект сервиса. Адаптер получает вызовы от клиента через методы клиентского интерфейса, 
    // а затем переводит их в вызовы методов обёрнутого объекта в правильном формате.
    {
        private readonly FahrenheitTemperatureSensor _sensor;

        public TemperatureSensorAdapter(FahrenheitTemperatureSensor sensor)
        {
            _sensor = sensor;
        }

        public double Measure()
        {
            return Math.Round((_sensor.Measure() - 32) / 1.8, 1, MidpointRounding.ToEven);
        }
    }
}