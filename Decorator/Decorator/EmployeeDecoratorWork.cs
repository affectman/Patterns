using System;

namespace Decorator.Decorator
{
	/// <summary>
	/// Класс-декоратор работы сотрудника.
	/// </summary>
	public class EmployeeDecoratorWork : EmployeeDecoratorBase
	{
		/// <summary>
		/// Контруктор класса.
		/// </summary>
		/// <param name="employee">Сотрудник.</param>
		public EmployeeDecoratorWork(AbstractEmployee employee) : base(employee)
		{
		}

		/// <summary>
		/// Выполняет работу сотрудника.
		/// </summary>
		public override void Work()
		{
			base.Work();
			Console.WriteLine("Я выполнил работу!");
		}
	}
}
