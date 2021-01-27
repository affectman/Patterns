using System;

namespace Decorator
{
	/// <summary>
	/// Бесплатный сотрудник.
	/// </summary>
	public class EmployeeFree : AbstractEmployee
	{
		/// <summary>
		/// Выполняет работу.
		/// </summary>
		public override void Work()
		{
			Console.WriteLine("Я волонтер и работаю бесплатно");
		}

	}
}
