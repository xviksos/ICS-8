using System.Collections.Generic;

namespace Lab9Command
{
    internal class ControlUnit
    {
        // Класс Получатель. Получатель содержит бизнес-логику программы. В этой роли может выступать практически любой объект.
        // Обычно команды перенаправляют вызовы получателям. Но иногда, чтобы упростить программу, вы можете избавиться от 
        // получателей, «слив» их код в классы команд.
        private readonly List<Command> _commands = new List<Command>();
        private int _current;

        public void StoreCommand(Command command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommand()
        {
            _commands[_current].Execute();
            _current++;
        }

        public void Undo()
        {
            _commands[_current - 1].UnExecute();
        }

        public void Redo()
        {
            _commands[_current - 1].Execute();
        }
        //добавлены методы многоуровневой отмены и повтора
        public void Undo(int i)
        {
            _commands[_current - i].UnExecute();
        }

        public void Redo(int i)
        {
            _commands[_current - i].Execute();
        }
    }
}