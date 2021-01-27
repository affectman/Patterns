using System;
using System.Collections.Generic;

namespace Command
{
    /// <summary>
    /// Пользователь (Отправитель).
    /// </summary>
    public class User
    {
        /// <summary>
        /// Калькулятор.
        /// </summary>
        private readonly Calculator _calculator = new Calculator();

        /// <summary>
        /// Список команд.
        /// </summary>
        private readonly List<Command> _commands = new List<Command>();

        /// <summary>
        /// Текущее значение.
        /// </summary>
        private int _current = 0;

        /// <summary>
        /// Повторение операций.
        /// </summary>
        /// <param name="levels"> Уровни. </param>
        public void Redo(int levels)
        {
            Console.WriteLine($"Повтор {levels} уровней.");

            for (var i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    var command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        /// <summary>
        /// Отменить операцию.
        /// </summary>
        /// <param name="levels"> Уровни. </param>
        public void Undo(int levels)
        {
            Console.WriteLine($"Отмена {levels} уровней.");

            for (var i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    var command = _commands[--_current];
                    command.UnExecute();
                }
            }
        }

        /// <summary>
        /// Рассчитать.
        /// </summary>
        /// <param name="command"> Оператор. </param>
        /// <param name="operand"> Аргумент. </param>
        public void Compute(char command, int operand)
        {
            Console.Write("Расчет: ");
            Command computeCommand = new CalculatorCommand(_calculator, command, operand);
            computeCommand.Execute();

            _commands.Add(computeCommand);
            _current++;
        }
    }
}
