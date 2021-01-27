using System;
using Visitor.Staff;

namespace Visitor.Visitor
{
    /// <summary>
    /// Дни отпуска сотрудника.
    /// </summary>
    public class VacationVisitor : IVisitor
    {
        /// <summary>
        /// Увеличение дней отпуска.
        /// </summary>
        /// <param name="element"> Сотрудник. </param>
        public void Visit(Element element)
        {
            switch (element)
            {
                case null:
                    throw new ArgumentNullException(nameof(element));
                case Employee employee:
                    employee.VacationDays += 3;
                    Console.WriteLine($"Должность: {employee.GetType().Name}, Имя: {employee.Name}, новое кол-во дней отпуска: = {employee.VacationDays}");
                    break;
            }
        }
    }
}
