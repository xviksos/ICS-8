using System;

namespace Lab8ChainOfResponsibility
{

    // Ниже идут конкретные обработчики. Конкретные обработчики содержат код обработки запросов. При получении 
    // запроса каждый обработчик решает, может ли он обработать запрос, а также стоит ли передать его следующему объекту.
    // В большинстве случаев обработчики могут работать сами по себе и быть неизменяемыми, получив все нужные детали через параметры конструктора.

    // Помимо конкретных обработчиков могут существовать Базовые обработчики. Базовый обработчик — опциональный класс, который позволяет избавиться от дублирования одного 
    // и того же кода во всех конкретных обработчиках. Обычно этот класс имеет поле для хранения ссылки на следующий обработчик в цепочке.Клиент связывает обработчики в цепь, 
    // подавая ссылку на следующий обработчик через конструктор или сеттер поля.Также здесь можно реализовать базовый метод обработки, который бы просто перенаправлял запрос 
    // следующему обработчику, проверив его наличие.
    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Выполняем банковский перевод");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Выполняем перевод через системы денежных переводов");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("Выполняем перевод через PayPal");
            else if (Successor != null)
                Successor.Handle(receiver);
        }
    }
        
    
}
