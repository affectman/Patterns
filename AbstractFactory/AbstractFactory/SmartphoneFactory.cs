using AbstractFactory.AbstractSpecifications;

namespace AbstractFactory.AbstractFactory
{
	/// <summary>
	/// Фабрика смартфона.
	/// </summary>
    public abstract class SmartphoneFactory
    {
		/// <summary>
		/// Получение процессора.
		/// </summary>
		/// <returns>Объект процессор.</returns>
		public abstract Cpu GetCpu();

		/// <summary>
		/// Получение оперативной памяти.
		/// </summary>
		/// <returns>Объект оперативная память.</returns>
		public abstract Ram GetRam();

		/// <summary>
		/// Получение батареи.
		/// </summary>
		/// <returns>Объект батарея.</returns>
		public abstract Battery GetBattery();
	}
}
