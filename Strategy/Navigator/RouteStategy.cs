namespace Lab5Strategy.Navigator
{
    // Стратегия определяет интерфейс, общий для всех вариаций алгоритма. Контекст использует этот интерфейс для вызова алгоритма.
    // Все остальные классы (Кроме NavigatorApp) являются конкретными стратегиями
    internal abstract class RouteStategy
    {
        public string Type { get; set; }

        public abstract string Build(string start, string finish);
    }
}