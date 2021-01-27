using System;

namespace Decorator.Decorator
{
	/// <summary>
	/// Класс-декоратор отдыха сотрудника.
	/// </summary>
	public class EmployeeDecoratorChillOut : EmployeeDecoratorBase
	{
		/// <summary>
		/// Контруктор отдыха.
		/// </summary>
		/// <param name="employee">Сотрудник.</param>
		public EmployeeDecoratorChillOut(AbstractEmployee employee) : base(employee)
		{
		}

		/// <summary>
		/// Выполняет работу сотрудника.
		/// </summary>
		public override void Work()
		{
			base.Work();
			Console.WriteLine("Расслабляюсь после работы");
		}
	}
}
