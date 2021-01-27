namespace Decorator
{
	/// <summary>
	/// Сотрудник.
	/// </summary>
	public abstract class AbstractEmployee
	{
		/// <summary>
		/// Идентификатор.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Имя.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Выполнить работу.
		/// </summary>
		public abstract void Work();
	}
}
