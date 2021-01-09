namespace Lab8ChainOfResponsibility
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Цепочка обязанностей — это поведенческий паттерн проектирования, который позволяет
            // передавать запросы последовательно по цепочке обработчиков. Каждый последующий обработчик
            // решает, может ли он обработать запрос сам и стоит ли передавать запрос дальше по цепи.

            // Данный класс является Клиентом. Клиент может либо сформировать цепочку обработчиков единожды,
            // либо перестраивать её динамически, в зависимости от логики программы. Клиент может отправлять
            // запросы любому из объектов цепочки, не обязательно первому из них.

            //определяем доступные классы
            var receiver = new Receiver(false, true, true) ;

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHnadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();


            //выстраиваем цепочку
            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHnadler;
            moneyPaymentHnadler.Successor = bankPaymentHandler;
            bankPaymentHandler.Handle(receiver);



        }
    }
}