using System;

namespace Lab4Singleton.Factory
{
    // Класс-Синглтон. Для реализации техники отложенной инициализации в C# рекомендуется использовать
    // класс Lazy<T>, экземпляры которого являются потокобезопасными. 
    // в результате при потпытке создать новый экземпляр AudiFactory при уже существующем - вернется ссылка уже существующего экземпляра
    internal class AudiFactory : CarFactory

    {

        private static readonly Lazy<AudiFactory> audiFactory = new Lazy<AudiFactory>(() => new AudiFactory());

        public static AudiFactory GetAudiFactory => audiFactory.Value;
        
        public static AudiFactory Factory => audiFactory.Value;

        public override Engine CreateEngine() => new AudiEngine();

        public override Car CreateCar() => new AudiCar("Audi");

        public override Body CreateBody() => new AudiBody();
    }

    internal class AudiCar : Car
    {
        public AudiCar(string name) => Name = name;

        public override int MaxSpeed(Engine engine) => engine.MaxSpeed;

        public override string ToString() => "Car" + Name;
    }

    internal class AudiEngine : Engine
    {
        public AudiEngine() => MaxSpeed = 300;
    }

    internal class AudiBody : Body
    {
        public AudiBody()
        {
            BodyType = "Coupe";
        }
    }
}