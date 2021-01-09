namespace Lab10Decorator
{
    //добавлен класс для нового автомобиля и были добавлены возможности TrackingSystemи new AutoPilotSystem(
    internal class Audi : AutoBase
    {
        // Класс является Конкретным Компонентом. Конкретный компонент определяет класс оборачиваемых объектов. 
        // Он содержит какое-то базовое поведение, которое потом изменяют декораторы.
        public Audi(string name, string info, double costbase)
        {
            Name = name;
            Description = info;
            CostBase = costbase;
        }

        public override double GetCost()
        {
            return CostBase * 3;
        }
    }
}