namespace AbstractFactory.AbstractSpecifications
{
	/// <summary>
	/// Абстрактный класс оперативной памяти.
	/// </summary>
    public abstract class Ram
	{
		/// <summary>
		/// Марка оперативной памяти.
		/// </summary>
		public string RamName { get; set; }

		/// <summary>
		/// Объем оперативной памяти.
		/// </summary>
		public int RamAmount { get; set; }
	}
}
