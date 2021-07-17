using System;

namespace Project
{
    class Program
    {
        static string[] CreateUserPets(int value)
        {
            string[] userPets = new string[value];

            for (int i = 0; i < value; i++)
            {
                Console.Write("\tВведите кличку питомца {0}: ", i + 1);
                userPets[i] = Console.ReadLine();
            }

            return userPets;
        }

        static string[] CreateUserColors(int value)
        {
            string[] userColors = new string[value];

            for (int i = 0; i < value; i++)
            {
                Console.Write("\tВведите любимый цвет номер {0}: ", i + 1);
                userColors[i] = Console.ReadLine();
            }

            return userColors;
        }

        static void GetTuple((string Name, string lastName, int age, bool isPet, int quantityPet, string[] pets, bool isColor, int quantityColors, string[] colors) User)
        {
            Console.WriteLine("\n=== Вывод данных о пользователе ===");

            Console.WriteLine("Ваше имя: {0} {1}", User.Name, User.lastName);
            Console.WriteLine("Ваш возраст: {0}", User.age);


            {
                if (User.isPet)

                    Console.WriteLine("Количество ваших питомцев: {0}", User.quantityPet);

                else
                    Console.WriteLine("У вас нет питомцев");

                if (User.quantityPet != 0)
                {
                    for (int i = 0; i < User.quantityPet; i++)
                    {
                        Console.WriteLine("\tКличка питомца номер {0}: {1}", i + 1, User.pets[i]);
                    }
                }
            }

            {
                if (User.isColor)
                {
                    Console.WriteLine("Количество любимых цветов: {0}", User.quantityColors);
                }
                else
                    Console.WriteLine("У вас нет любимых цветов");

                if (User.quantityColors != 0)
                {
                    for (int i = 0; i < User.quantityColors; i++)
                    {
                        Console.WriteLine("\tЛюбимый цвет номер {0}: {1}", i + 1, User.colors[i]);
                    }
                }
            }
        }

        static int CheckNumber()
        {
            int value = 0;
            bool boolNumber = true;

            do
            {
                try
                {
                    value = int.Parse(Console.ReadLine());
                    boolNumber = false;

                    if (value <= 0)
                    {
                        Console.WriteLine("Введите значение больше 0");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Вы ввели некорретное значение, попробуйте еще раз!");
                }
            } while (boolNumber == true || value <= 0);

            return value;
        }

        static (string Name, string lastName, int age, bool isPet, int quantityPet, string[] pets, bool isColor, int quantityColors, string[] colors) NewUser()
        {
            (string Name, string lastName, int age, bool isPet, int quantityPet, string[] pets, bool isColor, int quantityColors, string[] colors) User;

            Console.Write("Введите свое имя: ");
            User.Name = Console.ReadLine();

            Console.Write("Введите свою фамилию: ");
            User.lastName = Console.ReadLine();

            Console.Write("Введите свой возраст: ");
            User.age = CheckNumber();

            Console.Write("Есть ли у вас питомец? (Да или Нет): ");
            User.isPet = Console.ReadLine().ToLower() == "да";

            {
                if (User.isPet)
                {
                    Console.Write("Введите количество питомцев: ");
                    User.quantityPet = CheckNumber();

                    User.pets = CreateUserPets(User.quantityPet);
                }
                else
                {
                    User.pets = null;
                    User.quantityPet = 0;
                }
            }

            Console.Write("Есть ли у вас любимый цвет? (Да или Нет): ");
            User.isColor = Console.ReadLine().ToLower() == "да";

            {
                if (User.isColor)
                {
                    Console.Write("Введите количество любимых цветов: ");
                    User.quantityColors = CheckNumber();

                    User.colors = CreateUserColors(User.quantityColors);
                }
                else
                {
                    User.colors = null;
                    User.quantityColors = 0;
                }
            }

            return (User.Name, User.lastName, User.age, User.isPet, User.quantityPet, User.pets, User.isColor, User.quantityColors, User.colors);
        }

        static void Main(string[] args)
        {
            var User1 = NewUser();

            GetTuple(User1);

            Console.ReadLine();
        }
    }
}