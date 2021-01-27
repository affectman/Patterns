using System;
using Visitor.Visitor;

namespace Visitor.Staff
{
    /// <summary>
    /// Сотрудник.
    /// </summary>
    public class Employee : Element
    {
        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Зарплата.
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Дни отпуска
        /// </summary>
        public int VacationDays { get; set; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name"> Имя. </param>
        /// <param name="salary"> Зарплата. </param>
        /// <param name="vacationDays"> Дни отпуска.</param>
        public Employee(string name, double salary, int vacationDays)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(name));
            }
            if (salary <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(salary));
            }
            if (vacationDays <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(vacationDays));
            }

            Name = name;
            Salary = salary;
            VacationDays = vacationDays;
        }

        /// <summary>
        /// Метод принятия посетителя.
        /// </summary>
        /// <param name="visitor"> Посетитель. </param>
        public override void Accept(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException(nameof(visitor));
            }
            visitor.Visit(this);
        }
    }
}
