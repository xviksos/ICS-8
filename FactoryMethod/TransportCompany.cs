namespace Lab3FactoryMethod
{
    internal abstract class TransportCompany
    {
        // Класс создатель. Создатель объявляет фабричный метод, который должен возвращать новые объекты продуктов.
        // Важно, чтобы тип результата совпадал с общим интерфейсом продуктов.
        public string Name { get; set; }
        
        protected TransportCompany(string name) => Name = name;
        
        public override string ToString() => Name;

        // Сам фабричный метод ниже. Зачастую фабричный метод объявляют абстрактным, чтобы заставить
        // все подклассы реализовать его по-своему. Но он может возвращать и некий стандартный продукт.
        public abstract TransportService Create(string name, int category);

        // Несмотря на название, важно понимать, что создание продуктов не является единственной функцией создателя. Обычно он содержит и другой полезный код работы с продуктом.
        // Аналогия: большая софтверная компания может иметь центр подготовки программистов, но основная задача компании — создавать программные продукты, а не готовить программистов.
    }

    // Ниже идут конкретные создатели. Конкретные создатели по-своему реализуют фабричный метод, производя те или иные конкретные продукты.
    //Фабричный метод не обязан всё время создавать новые объекты. Его можно переписать так, чтобы возвращать существующие объекты из какого-то хранилища или кэша.
    internal class TaxiTransportCompany : TransportCompany
    {
        public TaxiTransportCompany(string name) : base(name)
        {
        }

        public override TransportService Create(string name, int category)
        {
            return new TaxiServices(name, category);
        }
    }

    internal class ShipTransportCompany : TransportCompany
    {
        public ShipTransportCompany(string name) : base(name)
        {
        }

        public override TransportService Create(string name, int category)
        {
            return new Shipping(name, category);
        }
    }

    internal class DrunkDriverTransportCompany : TransportCompany
    {
        public DrunkDriverTransportCompany(string name) : base(name)
        {
        }

        public override TransportService Create(string name, int category)
        {
            return new Shipping(name, category);
        }
    }
}