using System;

namespace Observer
{
	class Program
	{
		static void Main(string[] args)
		{
			var chanelBpm = new YoutubeChanel("BpmOnline");
			var chanelCrm = new YoutubeChanel("СrmOnline");
			chanelBpm.AddVideo("Создание детали");
			var subBpm = new Subscriber("Влад");
			var subCrm = new Subscriber("Lena");
			chanelCrm.AddSubscriber(subCrm);
			chanelBpm.AddSubscriber(subBpm);
			chanelCrm.AddVideo("Создание crm с 0.");
			chanelBpm.AddVideo("Удаление детали");
            var videos = chanelCrm.GetAllVideos();
            foreach (var video in videos)
            {
                Console.WriteLine(video);
            }
			Console.ReadLine();
		}
	}
}
