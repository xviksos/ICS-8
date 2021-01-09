namespace Lab10Decorator
{
    internal class Renault : AutoBase
    {
        // Класс является Конкретным Компонентом. Конкретный компонент определяет класс оборачиваемых объектов. 
        // Он содержит какое-то базовое поведение, которое потом изменяют декораторы.
        public Renault(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }

        public override double GetCost() => CostBase * 1.18;
    }
}