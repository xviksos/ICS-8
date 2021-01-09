namespace Lab1Adapter.Climate
{
    public interface ITemperatureSensor
    // Клиентский интерфейс описывает протокол, через который клиент может работать с другими классами.
    {
        double Measure();
    }
}