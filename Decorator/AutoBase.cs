namespace Lab10Decorator
{
    internal abstract class AutoBase
    {
        // Класс Компонента. Компонент задаёт общий интерфейс обёрток и оборачиваемых объектов.
        public string Name { get; set; }
        public string Description { get; set; }
        public double CostBase { get; set; }

        public abstract double GetCost();

        public override string ToString()
        {
            return $"Your car: {Name}\nInfo: {Description}\nCost: {GetCost()}\n";
        }
    }
}