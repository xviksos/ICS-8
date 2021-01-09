namespace Lab9Command
{
    internal abstract class Command
    {
        // Команда описывает общий для всех конкретных команд интерфейс. Обычно здесь описан всего один метод для запуска команды.
        protected double Operand;
        protected ArithmeticUnit Unit;
        public abstract void Execute();
        public abstract void UnExecute();
    }
}