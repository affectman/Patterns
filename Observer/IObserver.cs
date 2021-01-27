namespace Observer
{
	/// <summary>
	/// Интерфейс представления наблюдателя.
	/// </summary>
	public interface IObserver
	{
		/// <summary>
		/// Подписка на уведомления.
		/// </summary>
		/// <param name="message">Сообщение.</param>
		/// <param name="chanelName">Название канала.</param>
		void Subscribe(string message, string chanelName);
	}
}
