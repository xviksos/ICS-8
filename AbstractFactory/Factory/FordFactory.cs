namespace Lab2AbstractFactory.Factory
{
    internal class FordFactory : CarFactory
    // Класс конекретной фабрики (Форд). Конкретные фабрики относятся каждая к своей вариации продуктов (FordCar/FordEngine) 
    // и реализуют методы абстрактной фабрики, позволяя создавать все продукты определённой вариации.
    {
        public override Car CreateCar()
        {
            return new FordCar("Ford");
        }

        public override Engine CreateEngine()
        {
            return new FordEngine();
        }

        public override Body CreateBody()
        {
            return new FordBody();
        }
    }

    // Конкретные продукты Ford
    internal class FordCar : Car
    {
        public FordCar(string name)
        {
            Name = name;
        }

        public override int GetMaxSpeed(Engine engine)
        {
            return engine.MaxSpeed;
        }
    }

    internal class FordEngine : Engine
    {
        public FordEngine()
        {
            MaxSpeed = 220;
        }
    }

    internal class FordBody : Body
    {
        public FordBody()
        {
            BodyType = "Sedan";
        }
    }
}