using FinalTaskModule7;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Module7
{
	
		

	class Program
	{
		static void Main(string[] args)
		{
			 User user1 = new User();


			SolarEngine solar = new SolarEngine(1); //СОЗДАЕМ ДВИГАТЕЛЬ

			Vehicle<SolarEngine> car1 = new Vehicle<SolarEngine>("BMW", "Машина без поворотников", 9999999, 1500000, "Синий", "Машина", solar); //СОЗДАЕМ МАШИНУ НА СОЛНЕЧНОЙ ЭНЕРГИИ

			Food cucumber = new Food("Огурец", "Овощь", 10, 210, 150, null); //СОЗДАЕМ ОГУРЕЦ
			Food tomato = new Food("Помидор", "Овощь", 15, 100, 20, null); //СОЗДАЕМ ПОМИДОР
			Food banana = new Food("Банан", "Фрукт", 40, 50, 30, null); //СОЗДАЕМ БАНАН
			Clothes tshirt = new Clothes("Футболка Kelvin Don", "Хлопчатобумажная футболка с принтом ", 5000, 100, "Белый", "Футболка"); //СОЗДАЕМ ФУТБОЛКУ
			Clothes coat = new Clothes("Пальто Lious Makarti", "100% Синтетика", 9999, 500, "Черный", "Пальто"); //СОЗДАЕМ ПАЛЬТО

			PickPointDelivery deliv = new PickPointDelivery("Пункт выдачи по адресу ..."); //СОЗДАЕМ ДОСТАВКУ В ПУНКТ ВЫДАЧИ

			Order<PickPointDelivery> order = new Order<PickPointDelivery>(deliv); //СОЗДАЕМ ОБЫЧНЫЙ ЗАКАЗ

			order.AddProduct(car1);
			order.AddProduct(cucumber);
			order.AddProduct(tomato);
			order.AddProduct(banana);   //ДОБАВЛЯЕМ ПРОДУКТЫ
			order.AddProduct(tshirt);
			order.AddProduct(coat);

			Console.ReadLine();

			Console.WriteLine(order[4].GetName() + " стоит " + order[4].GetCost()); //ПОЛУЧАЕМ ПРЕДМЕТ ПО ИНДЕКСУ И ВЫВОДИМ ЕГО ИНФОРМАЦИЮ НА ЭКРАН (НАЗВАНИЕ И СТОИМОСТЬ)

			Console.ReadLine();

			GasEngine gas = new GasEngine(1); //СОЗДАЕМ ДВИГАТЕЛЬ

			Vehicle<GasEngine> supercar = new Vehicle<GasEngine>("LAMBORGHINI", "Суперкар", 19999999, 1200000, "Желтый", "Машина", gas); //СОЗДАЕМ МАШИНУ НА БЕНЗИНЕ

			Clothes supercoat = new Clothes("Пальто Golden Шик", "100% из шерсти", 199999, 500, "Фиальковый", "Пальто"); //СОЗДАЕМ ПАЛЬТО

			HomeDelivery sDeliv = new HomeDelivery("Красная площидь 1"); //СОЗДАЕМ ДОСТАВКУ НА ДОМ

			FastOrder<HomeDelivery> sOrder = new FastOrder<HomeDelivery>(sDeliv); //СОЗДАЕМ  БЫСТРЫЙ ЗАКАЗ

			sOrder.AddProduct(supercoat);
			sOrder.AddProduct(supercar);

			Console.ReadLine();

			Console.WriteLine("Номер первого заказа: " + order.GetOrderNumber());
			Console.WriteLine("Номер второго заказа: " + sOrder.GetOrderNumber());

			Console.ReadLine();

			Console.WriteLine($"{order.ArrivingDay} первый заказ приедет по адресу {order.Delivery.GetAdress()} ({order.Delivery.DeliveryType})");
			Console.WriteLine($"{sOrder.ArrivingDay} второй заказ приедет по адресу {sOrder.Delivery.GetAdress()} ({sOrder.Delivery.DeliveryType})");

			Console.ReadLine();
			
			
		}
	}

}
