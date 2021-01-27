using System;

namespace Command
{
    /// <summary>
    /// Калькулятор (Приемник).
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Текущее значение.
        /// </summary>
        private int _currentValue;

        /// <summary>
        /// Операция.
        /// </summary>
        /// <param name="command"> Оператор. </param>
        /// <param name="operand"> Аргумент. </param>
        public void Operation(char command, int operand)
        {
            switch (command)
            {
                case '+': 
                    _currentValue += operand;
                    break;
                case '-': 
                    _currentValue -= operand;
                    break;
                case '*':
                    _currentValue *= operand;
                    break;
                case '/':
                    _currentValue /= operand;
                    break;
                default:
                    throw new ArgumentException($"Оператор {command} не найден.");
            }
            Console.WriteLine($"Текущее значение = {_currentValue} (Выполнена операция {command} на {operand})");
        }
    }
}
