using System;

namespace Lab9Command
{
    internal class Program
    {
        // Команда — это поведенческий паттерн проектирования, который превращает запросы в объекты, 
        // позволяя передавать их как аргументы при вызове методов, ставить запросы в очередь, логировать их, а также поддерживать отмену операций.

        // Данный класс является Клиентом. Клиент создаёт объекты конкретных команд, передавая в них все необходимые параметры, среди
        // которых могут быть и ссылки на объекты получателей. После этого клиент связывает объекты отправителей с созданными командами.
        private static void Main(string[] args)
        {
            var calculator = new Calculator();
            
            var result = calculator.Add(5);
            Console.WriteLine(result);
            result = calculator.Multiply(6);
            Console.WriteLine(result);
            result = calculator.Div(3);
            Console.WriteLine(result);
            result = calculator.Redo();
            Console.WriteLine(result);
            result = calculator.Undo(1);
            Console.WriteLine(result);
        }
    }
}