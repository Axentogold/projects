using System;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Task2
{
    class InformationVideoCommand : YouTubeCommand
    {
        readonly Client client;

        public InformationVideoCommand(Client client)
        {
            this.client = client;
        }

        public override void Run()
        {
            _ = GetVideoInformation();
        }

        public async Task GetVideoInformation()
        {
            var youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(client.VideoUrl);

            var title = video.Title;
            var description = video.Description;

            Console.WriteLine($"Название: \n\n{title}\n\n\nОписание: \n\n{description}");
        }


    }
}