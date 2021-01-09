using System;
using Lab6TemplateMethod.Drink;
using Lab6TemplateMethod.Math;

namespace Lab6TemplateMethod
{
    internal class Program
    {
        // Шаблонный метод — это поведенческий паттерн проектирования, который определяет скелет алгоритма, 
        // перекладывая ответственность за некоторые его шаги на подклассы. Паттерн позволяет подклассам переопределять шаги алгоритма, не меняя его общей структуры.
        private static void Main(string[] args)
        {
            Console.Write("First = ");
            var first = int.Parse(Console.ReadLine());
            Console.Write("Last = ");
            var last = int.Parse(Console.ReadLine());
            Console.Write("Delta = ");
            var delta = int.Parse(Console.ReadLine());

            var arithmetic = new ArithmeticProgression(first, last, delta);
            arithmetic.TemplateMethod();

            var geom = new GeometricProgression(first, last, delta);
            geom.TemplateMethod();

            Console.WriteLine();

            //Drink
            var maj = new beautiful();
            maj.Make();
            
            Console.WriteLine();
            
            var poc = new bald();
            poc.Make();
            
        }
    }
}