using System;

namespace Decorator.Decorator
{
	/// <summary>
	/// Базовый декоратор сотрудника.
	/// </summary>
	public abstract class EmployeeDecoratorBase : AbstractEmployee
	{
		/// <summary>
		/// Экзепляр сотрудника.
		/// </summary>
		private AbstractEmployee _employee;

		/// <summary>
		/// Конструктор декоратора.
		/// </summary> 
		/// <param name="employee">Сотрудник.</param>
		public EmployeeDecoratorBase(AbstractEmployee employee)
		{
            _employee = employee ?? throw new ArgumentNullException("Не найден сотрудник",nameof(employee));
		}

		/// <summary>
		/// Выполняет работу сотрудника.
		/// </summary>
		public override void Work()
		{
            _employee.Work();
		}
	}
}
