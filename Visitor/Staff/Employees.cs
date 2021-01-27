using System;
using System.Collections.Generic;
using Visitor.Visitor;

namespace Visitor.Staff
{
    /// <summary>
    /// Сотрудники.
    /// </summary>
    public class Employees
    {
        /// <summary>
        /// Список сотрудников.
        /// </summary>
        private readonly List<Employee> _employees = new List<Employee>();

        /// <summary>
        /// Добавить сотрудника в список.
        /// </summary>
        /// <param name="employee"> Сотрудник. </param>
        public void AttachEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            _employees.Add(employee);
        }

        /// <summary>
        /// Отклонить сотрудника.
        /// </summary>
        /// <param name="employee"> Сотрудник. </param>
        public void DetachEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            _employees.Remove(employee);
        }

        /// <summary>
        /// Утвердить список сотрудников.
        /// </summary>
        /// <param name="visitor"> Действие над сотрудниками. </param>
        public void AcceptEmployees(IVisitor visitor)
        {
            if (visitor == null)
            {
                throw new ArgumentNullException(nameof(visitor));
            }

            foreach (var employee in _employees)
            {
                employee.Accept(visitor);
            }
            Console.WriteLine();
        }
    }
}
