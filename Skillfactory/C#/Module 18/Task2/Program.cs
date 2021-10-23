using System;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            var client = new Client("https://www.youtube.com/watch?v=dQw4w9WgXcQ", "dQw4w9WgXcQ");

            var informationVideoCommand = new InformationVideoCommand(client);
            var downloadVideoCommand = new DownloadVideoCommand(client);

            var sender = new Sender();

            sender.SetCommand(informationVideoCommand);
            sender.Run();
            sender.SetCommand(downloadVideoCommand);
            sender.Run();

            Console.ReadLine();
        }
    }
}