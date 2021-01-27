using System;

namespace observerEvent
{
	/// <summary>
	/// Подписчик.
	/// </summary>
	public class YoutubeSubscriber
	{
		/// <summary>
		/// Имя подписчика.
		/// </summary>
		private readonly string _name;

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="name">Имя подписчика.</param>
		public YoutubeSubscriber(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("Имя задано неверно", nameof(name));
			}

			_name = name;
		}

		/// <summary>
		/// Уведомление о новом видео.
		/// </summary>
		/// <param name="newVideo">Новое видео.</param>
		public void Notify(YoutubeVideo newVideo)
		{
			Console.WriteLine($"Пользователь {_name} уведомлен о новом видео {newVideo.Name}.");
		}
	}
}
