using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskModule7
{
	abstract class Delivery
	{
		public string DeliveryType;

		protected string Address;

		protected int cost;

		public string GetAdress()
		{
			return Address;
		}
	}
	class HomeDelivery : Delivery
	{
		public HomeDelivery(string address)
		{
			DeliveryType = "Доставка на дом";
			Address = address;
			cost = 500;
		}
	}

	class PickPointDelivery : Delivery
	{
		public PickPointDelivery(string address)
		{
			DeliveryType = "Доставка в пункт выдачи";
			Address = address;
			cost = 100;
		}
	}

	class ShopDelivery : Delivery
	{
		public ShopDelivery(string address)
		{
			DeliveryType = "Доставка в магазин";
			Address = address;
			cost = 0;
		}
	}
		
}
