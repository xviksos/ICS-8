using System;

namespace Lab1Adapter.Climate
{
    public class TemperatureSensorAdapter : ITemperatureSensor
    // ��������� ���������� ��������� � �������� ������ �� ������ �������. ������� �������� ������ �� ������� ����� ������ ����������� ����������, 
    // � ����� ��������� �� � ������ ������� ��������� ������� � ���������� �������.
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