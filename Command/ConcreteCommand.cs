namespace Lab9Command
{
    // Конкретные команды. Конкретные команды реализуют различные запросы, следуя общему интерфейсу команд. 
    // Обычно команда не делает всю работу самостоятельно, а лишь передаёт вызов получателю, которым является один из объектов бизнес-логики.

    // Параметры, с которыми команда обращается к получателю, следует хранить в виде полей.В большинстве случаев 
    // объекты команд можно сделать неизменяемыми, передавая в них все необходимые параметры только через конструктор.
    internal class Add : Command
    {
        public Add(ArithmeticUnit unit, double operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('+', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('-', Operand);
        }
    }
    //добавлена команда вычитания
    internal class Sub : Command
    {
        public Sub(ArithmeticUnit unit, double operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('-', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('+', Operand);
        }
    }
    //+умножение
    internal class Multiply : Command
    {
        public Multiply(ArithmeticUnit unit, double operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('*', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('/', Operand);
        }
    }
    //деление
    internal class Div : Command
    {
        public Div(ArithmeticUnit unit, double operand)
        {
            Unit = unit;
            Operand = operand;
        }

        public override void Execute()
        {
            Unit.Run('/', Operand);
        }

        public override void UnExecute()
        {
            Unit.Run('*', Operand);
        }
    }
}