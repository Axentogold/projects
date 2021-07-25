using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskModule7
{
	class User
	{
		private static bool Registration = true;

		private string name = null;
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				if (Registration)
				name = value;									

			}
		}

		private int age = 0;

		public int Age
		{
			get
			{
				return age;
			}

			set
			{
				if (Registration)
				
					if (value > 18)
						age = value;
					else
						Console.WriteLine("Вы должны быть старше 18 лет");
				
				
			}
		}

		public User()
		{
			while (name == null)
			{
				Console.Write("Введите ваше имя: ");
				Name = Console.ReadLine();
			}

			while (age == 0)
			{
				Console.Write("Введите ваше возраст: ");
				if (Int32.TryParse(Console.ReadLine(), out int userAge))
					Age = userAge;
			}
		}
	}
}
