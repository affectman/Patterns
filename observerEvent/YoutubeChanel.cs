using System;

namespace observerEvent
{
	/// <summary>
	/// Канал на ютубе.
	/// </summary>
    public class YoutubeChanel
	{
		/// <summary>
		/// Название канала.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="name"></param>
		public YoutubeChanel(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("Имя задано неверно", nameof(name));
			}

			Name = name;
		}

		/// <summary>
		/// Делегат для нового видео.
		/// </summary>
		/// <param name="newVideo">Видео.</param>
		public delegate void NewVideo(YoutubeVideo newVideo);


        /// <summary>
        /// Добавление и удаление подписчиков.
        /// </summary>
        public event NewVideo OnNewVideo;

        /// <summary>
		/// Создание новое видео.
		/// </summary>
		/// <param name="name">Название.</param>
		/// <param name="content">Описание.</param>
		public void CreateNewVideo(string name, string content)
		{
			if (string.IsNullOrWhiteSpace(name))
			{
				throw new ArgumentException("Имя задано неверно", nameof(name));
			}

			if (string.IsNullOrWhiteSpace(content))
			{
				throw new ArgumentException("Нужно заполнить описание.", nameof(content));
			}

			var newVideo = new YoutubeVideo
			{
				Name = name,
				Content = content
			};

			NotificationSubscribers(newVideo);
		}

        /// <summary>
		/// Уведомление подписчиков.
		/// </summary>
		/// <param name="newVideo"> Новое видео.</param>
		private void NotificationSubscribers(YoutubeVideo? newVideo)
        {
            if (newVideo == null)
            {
				throw new ArgumentException("Нужно заполнить описание.", nameof(newVideo));
			}

            OnNewVideo?.Invoke((YoutubeVideo)newVideo);
        }

    }
}
