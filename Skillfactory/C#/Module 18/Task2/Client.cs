
namespace Task2
{
    class Client
    {
        public string VideoUrl { get; set; }
        public string StreamManifest { get; set; }

        public Client(string videoUrl, string streamManifest)
        {
            VideoUrl = videoUrl;
            StreamManifest = streamManifest;
        }

    }
}