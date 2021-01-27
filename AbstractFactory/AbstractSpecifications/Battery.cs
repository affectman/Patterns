namespace AbstractFactory.AbstractSpecifications
{
	/// <summary>
	/// Абстрактный класс батареи. 
	/// </summary>
    public abstract class Battery
	{
		/// <summary>
		/// Единица измерения батареи.
		/// </summary>
		public string BatteryUnitOfMeasurement { get; set; }
		
		/// <summary>
		/// Емкость батареи.
		/// </summary>
		public int BatteryCapacity { get; set; }

    }
}
