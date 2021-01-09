namespace Lab1Adapter.Game
{
    public class Gamer
    // Класс-клиент, который содержит существующую бизнес-логику программы и 
    // имеет доступ к архитектуре адаптера через интерфейс
    {
        public Gamer(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int Start(IGame game)
        {
            return game.Roll();
        }
    }
}