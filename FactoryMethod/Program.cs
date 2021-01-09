using System;

namespace Lab3FactoryMethod
{
    internal class Program
    {
        // Фабричный метод — это порождающий паттерн проектирования, который определяет общий интерфейс
        // для создания объектов в суперклассе, позволяя подклассам изменять тип создаваемых объектов. 
        private static void Main(string[] args)
        {
            var taxiCompany = new TaxiTransportCompany("Taxi Service");
            var taxi = taxiCompany.Create("Taxi", 1);
            Print(taxi, 15);

            var shipCompany = new ShipTransportCompany("Shipping Service");
            taxi = shipCompany.Create("Shipment", 2);
            Print(taxi, 150);

            var drunkDriverCompany = new DrunkDriverTransportCompany("Drunk Driver Service");//функция пьяный водитель
            taxi = drunkDriverCompany.Create("Drunk Driver", 3);

            Print(taxi, 100);
        }

        private static void Print(TransportService transportService, double distance)
        // Просто метод вывода данных
        {
            Console.WriteLine("Transport company: {0}, distance: {1}, cost: {2}",
                transportService, distance, transportService.CostTransportation(distance));
        }
    }
}