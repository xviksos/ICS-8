namespace Lab5Strategy.Sorting
{
    internal class Bubble : SortStrategy
    {
        // Класс конкретной стратегии. Конкретные стратегии реализуют различные вариации алгоритма
        public Bubble() => Title = "Bubble Sort";

        public override string ToString() => Title;

        public override void Sort(int[] array)
        {
            int temp;
            for (var i = 0; i < array.Length - 1; i++)
            for (var j = i + 1; j < array.Length; j++)
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
        }
    }
}