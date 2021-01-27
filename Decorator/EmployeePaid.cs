using System;

namespace Decorator
{
	/// <summary>
	/// Платный сотрудник.
	/// </summary>
	public class EmployeePaid : AbstractEmployee
	{
		/// <summary>
		/// Выполняет работу.
		/// </summary>
		public override void Work()
		{
			Console.WriteLine("Я обычный работник и работаю за деньги");
		}
	}
}
