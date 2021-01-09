﻿namespace Lab6TemplateMethod.Math
{
    internal class GeometricProgression : Progression
    {
        // Ещё один конкретный класс
        public GeometricProgression(int first, int last, int delta) : base(first, last, delta)
        {
        }

        public override void Progress()
        {
            var element = First;
            do
            {
                Sequence.Add(element);
                element = element * Delta;
            } while (element <= Last);
        }
    }
}