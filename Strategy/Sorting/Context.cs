using System;

namespace Lab5Strategy.Sorting
{
    internal class Context
    {
        // Класс контекста. Контекст хранит ссылку на объект конкретной стратегии, работая с ним через общий интерфейс стратегий.
        private readonly int[] _array;
        private readonly SortStrategy _sortStrategy;

        public Context(SortStrategy sortStrategy, int[] array)
        {
            _sortStrategy = sortStrategy;
            _array = array;
        }

        public void Sort() => _sortStrategy.Sort(_array);

        public void PrintArray()
        {
            Console.WriteLine(_sortStrategy.ToString());
            foreach (var element in _array)
                Console.Write(element + " ");

            Console.WriteLine();
        }
    }
}