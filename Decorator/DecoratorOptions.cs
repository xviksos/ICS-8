using System;

namespace Lab10Decorator
{
    abstract class DecoratorOptions : AutoBase
    {
        // Класс Базового Декоратора. Базовый декоратор хранит ссылку на вложенный объект-компонент. Им может быть как
        // конкретный компонент, так и один из конкретных декораторов. Базовый декоратор делегирует все свои операции
        // вложенному объекту. Дополнительное поведение будет жить в конкретных декораторах.
        public DecoratorOptions(AutoBase au, string title)
        {
            AutoProperty = au;
            Title = title;
        }

        public AutoBase AutoProperty { protected get; set; }
        public string Title { get; set; }
    }
}