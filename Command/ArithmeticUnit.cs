namespace Lab9Command
{
    internal class ArithmeticUnit
    {
        // Класс бизнес-логики операторов.
        public double Register { get; private set; }

        public void Run(char operationCode, double operand)
        {
            switch (operationCode)
            {
                case '+':
                    Register += operand;
                    break;
                case '-':
                    Register -= operand;
                    break;
                case '*':
                    Register *= operand;
                    break;
                case '/':
                    Register /= operand;
                    break;
            }
        }
    }
}