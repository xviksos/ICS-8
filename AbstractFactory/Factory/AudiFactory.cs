namespace Lab2AbstractFactory.Factory
{
    internal class AudiFactory : CarFactory
    // Класс конекретной фабрики (Ауди). Конкретные фабрики относятся каждая к своей вариации продуктов (AudiCar/AudiEngine) 
    // и реализуют методы абстрактной фабрики, позволяя создавать все продукты определённой вариации.
    {
        public override Engine CreateEngine()
        {
            return new AudiEngine();
        }

        public override Car CreateCar()
        {
            return new AudiCar("Audi");
        }

        public override Body CreateBody()
        {
            return new AudiBody();
        }
    }

    // Ниже идут конкретные продукты Audi
    internal class AudiCar : Car
    {
        public AudiCar(string name)
        {
            Name = name;
        }

        public override int GetMaxSpeed(Engine engine)
        {
            return engine.MaxSpeed;
        }
    }

    internal class AudiEngine : Engine
    {
        public AudiEngine()
        {
            MaxSpeed = 200;
        }
    }

    internal class AudiBody : Body
    {
        public AudiBody()
        {
            BodyType = "Coupe";
        }
    }
}