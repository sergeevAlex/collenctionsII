using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegation
{
	abstract class Vehicle
	{
		static protected Exception OutOfMaxBorder = new Exception("Превышена максимальна граница");
		static protected Exception NonBellowZero = new Exception("Введенное значение не может быть отрицательным!");

		protected int price, maxspeed, year;
		public int Price
		{
			get { return price; }
			set { if (value > 0) price = value; }
		}

		public int Maxspeed
		{
			get { return maxspeed; }
			set { if (value > 0) maxspeed = value; }
		}

		public int Year_create
		{
			get { return year; }
			set { if (value <= DateTime.Today.Year) year = value; }
		}
		public Vehicle(int price, int maxspeed, int year)
		{
			this.Price = price;
			this.Maxspeed = maxspeed;
			this.Year_create = year;
		}
	}
}