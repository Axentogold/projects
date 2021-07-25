using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalTaskModule7
{
	abstract class Product
	{
		protected string name;
		protected string description;
		protected int cost;
		protected float weight;
		protected string color;

		
		public string GetName()
		{
			return name;
		}

		public string GetDescription()
		{
			return description;
		}

		public int GetCost()
		{
			return cost;
		}

		public float GetWeight()
		{
			return weight;
		}

		public void CreateBase(string name, string description, int cost, float weight, string color)
		{
			this.name = name;
			this.description = description;
			this.cost = cost;
			this.weight = weight;
			this.color = color;
		}
	}

	class Vehicle<TEngine> : Product
		where TEngine : Engine
	{
		private string transportType;

		private TEngine Engine;

		public Vehicle(string name, string description, int cost, float weight, string color, string transportType, TEngine engine)
		{
			CreateBase(name, description, cost, weight, color);
			this.transportType = transportType;
			Engine = engine;
		}

		public string GetTransportType()
		{
			return transportType;
		}

		public TEngine GetEngine()
		{
			return Engine;
		}

		public string GetEngineType()
		{
			return Engine.EngineType;
		}
				
	}
		
	
	abstract class Engine : Product
	{
		public string EngineType;

		protected int power;

		public string GetEngineType()
		{
			return EngineType;
		}

		public int GetPower()
		{
			return power;
		}
	}

	class SolarEngine : Engine
	{
		public SolarEngine(int variation = 1)
		{
			
			EngineType = "Двигатель на солнечной энергии";

			if (variation > 0 && variation < 4)
			{
				switch (variation)
				{
					case 1:
						power = 1000;
						cost = 10000;
						break;

					case 2:
						power = 2000;
						cost = 20000;
						break;

					case 3:
						power = 30000;
						cost = 30000;
						break;
				}
			}
			else
			{
				power = 1000;
				cost = 10000;
			}
		}
	}

	class GasEngine : Engine
	{
		public GasEngine(int variation = 1)
		{
			
			EngineType = "Двигатель на бензине";

			if (variation > 0 && variation < 4)
			{
				switch (variation)
				{
					case 1:
						power = 1500;
						cost = 15000;
						break;

					case 2:
						power = 2500;
						cost = 25000;
						break;

					case 3:
						power = 3500;
						cost = 35000;
						break;
				}
			}
			else
			{
				power = 1500;
				cost = 15000;
			}
		}
	}

	class Food : Product
	{
		public string FoodType;

		public int Calories;

		public Food(string name, string foodType, int calories, float weight, int cost, string description)
		{
			CreateBase(name, description, cost, weight, null);
			Calories = calories;
			FoodType = foodType;
		}
	}

	class Clothes : Product
	{
		public string ClothType;

		public Clothes(string name, string description, int cost, float weight, string color, string clothType)
		{
			CreateBase(name, description, cost, weight, color);
			ClothType = clothType;
		}
	}

}
