using System;
using System.Threading;

namespace Module_12
{
    class Program
    {
        static void Main()
        {
            var user1 = new User { Login = "lgn1", Name = "Вася", IsPremium = false };
            var user2 = new User { Login = "lgn2", Name = "Петя", IsPremium = true };

            GreetingUser(user1);
            Console.WriteLine();

            GreetingUser(user2);

            Console.ReadKey();
        }

        static void GreetingUser(User user)
        {
            Console.WriteLine($"Привет, {user.Name}");

            if (!user.IsPremium)
                ShowAds();
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }

    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }
}