using System;

namespace observerEvent
{
	class Program
	{
		static void Main(string[] args)
		{
			var youtubeGenerator = new YoutubeChanel("It");
			var firstSub = new YoutubeSubscriber("Hola");
			var secondSub = new YoutubeSubscriber("Bola");
			youtubeGenerator.OnNewVideo += firstSub.Notify;
			youtubeGenerator.CreateNewVideo("Создание ватрушек", "созднание плюшек");
			youtubeGenerator.CreateNewVideo("Водопад", "пад пад");
			youtubeGenerator.OnNewVideo += secondSub.Notify;
			youtubeGenerator.CreateNewVideo("Поход в магазин", "пам пам");
			Console.ReadLine();
		}
	}
}

