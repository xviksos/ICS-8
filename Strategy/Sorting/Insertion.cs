namespace Lab5Strategy.Sorting
{
    internal class Insertion : SortStrategy
    {
        // Класс конкретной стратегии. Конкретные стратегии реализуют различные вариации алгоритма
        public Insertion() => Title = "Insertion Sort";

        public override string ToString() => Title;

        public override void Sort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var j = 0;
                var buffer = array[i];
                for (j = i - 1; j >= 0; j--)
                {
                    if (array[j] < buffer)
                        break;
                    array[j + 1] = array[j];
                }

                array[j + 1] = buffer;
            }
        }
    }
}