using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Task2
{
    class DownloadVideoCommand : YouTubeCommand
    {
        readonly Client client;

        public DownloadVideoCommand(Client client)
        {
            this.client = client;
        }

        public override void Run()
        {
            _ = DownloadVideo();
        }

        public async Task DownloadVideo()
        {
            var youtube = new YoutubeClient();

            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(client.StreamManifest);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }
    }
}