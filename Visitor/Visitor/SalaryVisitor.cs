using System;
using Visitor.Staff;

namespace Visitor.Visitor
{
    /// <summary>
    /// Зарплата сотрудника. 
    /// </summary>
    public class SalaryVisitor : IVisitor
    {
        /// <summary>
        /// Увеличение ЗП.
        /// </summary>
        /// <param name="element">Сотрудник.</param>
        public void Visit(Element element)
        {
            if (element == null)
            {
                throw new ArgumentNullException(nameof(element));
            }
            var employee = (Employee) element;

            employee.Salary *= 1.10;
            Console.WriteLine($"Должность: {employee.GetType().Name}, Имя: {employee.Name}, Новая ЗП = {employee.Salary}");
        }
    }
}
