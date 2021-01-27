using System;

namespace Command
{
    /// <summary>
    /// Команда калькулятора.
    /// </summary>
    internal class CalculatorCommand : Command
    {
        /// <summary>
        /// Оператор.
        /// </summary>
        private readonly char _operator;

        /// <summary>
        /// Аргумент.
        /// </summary>
        private readonly int _operand;

        /// <summary>
        /// Калькулятор.
        /// </summary>
        private readonly Calculator _calculator;

        // Constructor

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="calculator"> Калькулятор. </param>
        /// <param name="command"> Оператор. </param>
        /// <param name="operand"> Аргумент. </param>
        public CalculatorCommand(Calculator calculator, char command, int operand)
        {
            _calculator = calculator ?? throw new ArgumentNullException(nameof(calculator));
            _operator = command;
            _operand = operand;
        }

        /// <summary>
        /// Выполнить операцию.
        /// </summary>
        public override void Execute()
        {
            _calculator.Operation(_operator, _operand);
        }

        /// <summary>
        /// Отменить последнюю операцию.
        /// </summary>
        public override void UnExecute()
        {
            _calculator.Operation(Undo(_operator), _operand);
        }

        /// <summary>
        /// Возвращает противоположный оператор для данного оператора.
        /// </summary>
        /// <param name="command"> Оператор. </param>
        /// <returns> Противоположный оператор. </returns>
        private static char Undo(char command)
        {
            switch (command)
            {
                case '+': 
                    return '-';
                case '-':
                    return '+';
                case '*':
                    return '/';
                case '/':
                    return '*';
                default:
                    throw new ArgumentException($"Оператор {command} не найден.");
            }
        }
    }
}
