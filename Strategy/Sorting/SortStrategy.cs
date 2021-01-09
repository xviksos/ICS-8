namespace Lab5Strategy.Sorting
{
    internal abstract class SortStrategy
    {
        // Стратегия определяет интерфейс, общий для всех вариаций алгоритма. Контекст использует этот интерфейс для вызова алгоритма.
        // Для контекста неважно, какая именно вариация алгоритма будет выбрана, так как все они имеют одинаковый интерфейс.
        public string Title { get; set; }
        public abstract void Sort(int[] array);
    }
}