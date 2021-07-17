using System;

namespace Project
{
    class Program
    {
        static string[] CreateUserPets(int pets)
        
        {
            var userPets = new string[pets];

            for (int i = 0; i < pets; i++)
            {
                Console.Write("\tВведите кличку питомца {0}: ", i + 1);
                userPets[i] = Console.ReadLine();
            }

            return userPets;
        } // заполнение массива питомцев

        static string[] CreateUserColors(int colors)
        {
            string[] userColors = new string[colors];

            for (int i = 0; i < colors; i++)
            {
                Console.Write("\tВведите любимый цвет номер {0}: ", i + 1);
                userColors[i] = Console.ReadLine();
            }

            return userColors;
        } // заполнение массива любимых цветов

        static void GetTuple((string name, string lastName, int age, bool isPet, int quantityPet, string[] pets, bool isColor, int quantityColors, string[] colors) user)
        {
            Console.WriteLine("\n=== Вывод данных о пользователе ===");

            Console.WriteLine("Ваше имя: {0} {1}", user.name, user.lastName);
            Console.WriteLine("Ваш возраст: {0}", user.age);


            {
                if (user.isPet)

                    Console.WriteLine("Количество ваших питомцев: {0}", user.quantityPet);

                else
                    Console.WriteLine("У вас нет питомцев");

                if (user.quantityPet != 0)
                
                    for (int i = 0; i < user.quantityPet; i++)
                    {
                        Console.WriteLine("\tКличка питомца номер {0}: {1}", i + 1, user.pets[i]);
                    }
                
            }

            {
                if (user.isColor)
                
                    Console.WriteLine("Количество любимых цветов: {0}", user.quantityColors);
                
                else
                    Console.WriteLine("У вас нет любимых цветов");

                if (user.quantityColors != 0)
                
                    for (int i = 0; i < user.quantityColors; i++)
                    {
                        Console.WriteLine("\tЛюбимый цвет номер {0}: {1}", i + 1, user.colors[i]);
                    }
                
            }
        } // Вывод данных о пользователе

        static int CheckNumber() // метод проверяет, чтобы пользователь вводил значения больше 0 и не принимает отрицательные значения
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

        static (string name, string lastName, int age, bool isPet, int quantityPet, string[] pets, bool isColor, int quantityColors, string[] colors) newUser() //ввод значений для нового пользователя          

        {
            (string name, string lastName, int age, bool isPet, int quantityPet, string[] pets, bool isColor, int quantityColors, string[] colors) user;

            Console.Write("Введите свое имя: ");
            user.name = Console.ReadLine();

            Console.Write("Введите свою фамилию: ");
            user.lastName = Console.ReadLine();

            Console.Write("Введите свой возраст: ");
            user.age = CheckNumber();

            Console.Write("Есть ли у вас питомец? (Да или Нет): ");
            user.isPet = Console.ReadLine().ToLower() == "да";

            {
                if (user.isPet)
                {
                    Console.Write("Введите количество питомцев: ");
                    user.quantityPet = CheckNumber();

                    user.pets = CreateUserPets(user.quantityPet);
                }
                else
                {
                    user.pets = null;
                    user.quantityPet = 0;
                }
            }

            Console.Write("Есть ли у вас любимый цвет? (Да или Нет): ");
            user.isColor = Console.ReadLine().ToLower() == "да";

            {
                if (user.isColor)
                {
                    Console.Write("Введите количество любимых цветов: ");
                    user.quantityColors = CheckNumber();

                    user.colors = CreateUserColors(user.quantityColors);
                }
                else
                {
                    user.colors = null;
                    user.quantityColors = 0;
                }
            }

            return (user);
        }

        static void Main(string[] args) 
        {
            var User1 = newUser();

            GetTuple(User1);

            Console.ReadLine();
        }
    }
}