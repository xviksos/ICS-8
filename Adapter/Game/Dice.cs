using System;

namespace Lab1Adapter.Game
{
    public class Dice : IGame
    // Этот класс является сервисом с полезным функционалом
    {
        private readonly Random _random;

        public Dice()
        {
            _random = new Random();
        }

        public int Roll()
        {
            return _random.Next(6) + 1;
        }
    }
}