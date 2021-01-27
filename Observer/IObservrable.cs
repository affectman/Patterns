namespace Observer
{
	/// <summary>
	/// Интерфейс предствляет наблюдаемый объект.
	/// </summary>
	public interface IObservrable
	{
		/// <summary>
		/// Добавление видео.
		/// </summary>
		/// <param name="nameVideo">Название видео.</param>
		void AddVideo(string nameVideo);

		/// <summary>
		/// Добавить подписчика.
		/// </summary>
		/// <param name="observer">Подписчик.</param>
		void AddSubscriber(IObserver subscriber);

		/// <summary>
		/// Удаление подписчика.
		/// </summary>
		/// <param name="subscriber"></param>
		void RemoveSubscriber(IObserver subscriber);

		/// <summary>
		/// Оповещение всех подписчиков.
		/// </summary>
		/// <param name="videoName">Название видео.</param>
		void NotifyAllSubscribers(string videoName);
	}
}
