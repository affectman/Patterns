using System;

namespace Observer
{
    /// <summary>
	/// Подписчик.
	/// </summary>
	public class Subscriber : IObserver
	{
		/// <summary>
		/// Имя пользователя.
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="username">Имя пользователя.</param>
		public Subscriber(string username)
		{
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Неверно задан параметр", nameof(username));
            }
            UserName = username;
		}

		/// <summary>
		/// Подписка на уведомления.
		/// </summary>
		/// <param name="message">Сообщение.</param>
		/// <param name="chanelName">Имя канала.</param>
		public void Subscribe(string message, string chanelName)
		{
            if (string.IsNullOrWhiteSpace(message))
            {
                throw new ArgumentException("Неверно задан параметр", nameof(message));
            }

            if (string.IsNullOrWhiteSpace(chanelName))
            {
                throw new ArgumentException("Неверно задан параметр", nameof(chanelName));
            }

            Console.WriteLine($"{message} {chanelName}");
		}
	}
}
