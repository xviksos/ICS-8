namespace Lab8ChainOfResponsibility
{
    internal abstract class PaymentHandler
    {
        // Класс-обработчик. Обработчик определяет общий для всех конкретных обработчиков интерфейс. 
        // Обычно достаточно описать единственный метод обработки запросов, но иногда здесь может быть объявлен и метод выставления следующего обработчика.
        public PaymentHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}