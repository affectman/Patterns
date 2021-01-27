namespace AbstractFactory.AbstractSpecifications
{
	/// <summary>
	/// Абстрактный класс процессора.
	/// </summary>
    public abstract class Cpu
	{
		/// <summary>
		/// Название процессора.
		/// </summary>
		public string CpuName { get; set; }

		/// <summary>
		/// Частота процессора.
		/// </summary>
		public int CpuFrequency { get; set; }
	}
}
