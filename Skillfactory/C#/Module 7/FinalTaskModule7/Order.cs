using Module7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskModule7
{
	class Order<TDelivery> where TDelivery : Delivery
	{
		public string ArrivingDay;

		private Product[] allProducts;

		public TDelivery Delivery;

		protected string number;

		public string Description;

		public string GetOrderNumber()
		{
			return number;
		}

		public void DisplayAddress()
		{
			Console.WriteLine(Delivery.GetAdress());
		}


		public Product this[int index]
		{
			get
			{
				if (index < allProducts.Length && index >= 0)
					return allProducts[index];

				Console.WriteLine("Такого продукта нет в заказе.");
				return null;
			}
		}

		public void AddProduct(Product product)
		{
			if (allProducts == null)
				allProducts = new Product[1] { product };
			else
			{
				Product[] temp = new Product[allProducts.Length + 1];
				for (int i = 0; i < allProducts.Length; i++)
					temp[i] = allProducts[i];
				temp[temp.Length - 1] = product;
				allProducts = temp;
			}

			Console.WriteLine("Продукт был успешно добавлен в заказ.");
		}

		public void AddDescription(string desc)
		{
			Description = desc;
		}

		public Order(TDelivery delivery)
		{
			Random rnd = new Random();

			number = "#" + rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString();

			ArrivingDay = "Через 5 дней";

			Delivery = delivery;
		}
	}

	class FastOrder<TDelivery> : Order<TDelivery>
		where TDelivery : Delivery
	{
		public FastOrder(TDelivery delivery) : base(delivery)
		{
			Random rnd = new Random();
			number = "#F" + rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString() + rnd.Next(0, 10).ToString();

			ArrivingDay = "Через 1 день";
		}
	}
}
