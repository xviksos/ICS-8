namespace Lab1Adapter.Game
{
    public class GameAdapter : IGame
    // Реализует клиентский интерфейс и содержит ссылку на объект сервиса. Адаптер получает вызовы от клиента через методы клиентского интерфейса, 
    // а затем переводит их в вызовы методов обёрнутого объекта в правильном формате.
    {
        private readonly Coin _coin;

        public GameAdapter(Coin coin)
        {
            _coin = coin;
        }

        public int Roll()
        {
            return _coin.Toss();
        }
    }
}