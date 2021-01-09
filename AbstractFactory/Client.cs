using Lab2AbstractFactory.Factory;

namespace Lab2AbstractFactory
{
    internal class Client
    // Клиентский код. Несмотря на то, что конкретные фабрики порождают конкретные продукты, сигнатуры их методов должны возвращать соответствующие абстрактные продукты.
    // Это позволит клиентскому коду, использующему фабрику, не привязываться к конкретным классам продуктов. Клиент сможет работать 
    // с любыми вариациями продуктов через абстрактные интерфейсы.
    {
        public Client(CarFactory carFactory)
        {
            Car = carFactory.CreateCar();
            Engine = carFactory.CreateEngine();
            Body = carFactory.CreateBody();
        }

        public Car Car { get; }
        public Engine Engine { get; }
        public Body Body { get; }

        public int RunMaxSpeed()
        {
            return Car.GetMaxSpeed(Engine);
        }

        public string GetBodyType()
        {
            return Car.GetBodyType(Body);
        }

        public override string ToString()
        {
            return Car.ToString();
        }
    }
}