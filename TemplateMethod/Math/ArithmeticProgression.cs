namespace Lab6TemplateMethod.Math
{
    internal class ArithmeticProgression : Progression
    {
        // Конкретный класс переопределяет некоторые (или все) шаги алгоритма. Конкретные классы не переопределяют сам шаблонный метод.
        public ArithmeticProgression(int first, int last, int delta) : base(first, last, delta)
        {
        }

        public override void Progress()
        {
            var element = First;
            do
            {
                Sequence.Add(element);
                element = element + Delta;
            } while (element < Last);
        }
    }
}