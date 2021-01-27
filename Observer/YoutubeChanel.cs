using System;
using System.Collections.Generic;

namespace Observer
{
	/// <summary>
	/// Класс канала на youtube.
	/// </summary>
	public class YoutubeChanel : IObservable
    {
		/// <summary>
		/// Название канала.
		/// </summary>
		public string ChanelName { get; set; }

		/// <summary>
		/// Список подписчиков.
		/// </summary>
		private readonly List<IObserver> _subscribers = new List<IObserver>();

		/// <summary>
		/// Список видеозаписей.
		/// </summary>
		private readonly List<string> _videos = new List<string>();

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="chanelName"></param>
		public YoutubeChanel(string chanelName)
		{
            if (string.IsNullOrWhiteSpace(chanelName))
            {
                throw new ArgumentException("Неверно задан параметр", nameof(chanelName));
            }
            ChanelName = chanelName;
		}

		/// <summary>
		/// Добавление видеозаписи на канал.
		/// </summary>
		/// <param name="videoName">Название видео.</param>
		public void AddVideo(string videoName)
		{
            if (string.IsNullOrWhiteSpace(videoName))
            {
                throw new ArgumentException("Неверно задан параметр", nameof(videoName));
            }
            _videos.Add(videoName);
			NotifyAllSubscribers(videoName);
		}

        /// <summary>
        /// Добавление подписчика.
        /// </summary>
        /// <param name="subscriber">Подписчик.</param>
        public void AddSubscriber(IObserver subscriber)
        {
            if (subscriber == null)
            {
                throw new ArgumentNullException("Подписчик не найден",nameof(subscriber));
            }
            _subscribers.Add(subscriber);
        }

        /// <summary>
        /// Удаление подписчика.
        /// </summary>
        /// <param name="subscriber">Подписчик.</param>
        public void RemoveSubscriber(IObserver subscriber)
        {
            if (subscriber == null)
            {
                throw new ArgumentNullException("Подписчик не найден", nameof(subscriber));
            }
            _subscribers.Remove(subscriber);
        }

		/// <summary>
		/// Оповещение всех подписчиков о новом видео.
		/// </summary>
		/// <param name="videoName">Название видео.</param>
		public void NotifyAllSubscribers(string videoName)
		{
            if (string.IsNullOrWhiteSpace(videoName))
            {
                throw new ArgumentException("Неверно задан параметр", nameof(videoName));
            }

            foreach (var sub in _subscribers)
			{
				sub.Subscribe($"Выпущено новое видео {videoName} на канале ", ChanelName);
			}
		}

        /// <summary>
        /// Получение всех видеозаписей с канала.
        /// </summary>
        /// <returns>Список видеозаписей.</returns>
        public List<string> GetAllVideos()
        {
            return _videos;
        }
	}


}
