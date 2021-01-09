using System;

namespace Lab1Adapter.Game
{
    public class Coin
    // Этот класс является сервисом с полезным функционалом
    {
        private readonly Random _random;

        public Coin()
        {
            _random = new Random();
        }

        public int Toss()
        {
            return _random.Next(2) + 1;
        }
    }
}