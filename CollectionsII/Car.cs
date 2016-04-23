using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegation
{
	class Car : Vehicle, IComparable<Car>
	{
		public int Power { get; set; }
		public Car(int prise, int maxspeed, int year, int Power) : base(prise, maxspeed, year)
		{
			this.Power = Power;
		}


		public override string ToString()
		{
			return String.Format("Цена: {0}\tМощность: {3}\tГод выпуска: {2}\tМаксимальная скорость: {1}",
				this.Price, this.maxspeed, this.year, this.Power);
		}

		public int CompareTo(Car obj)
		{
			if (this.Price > obj.Price)
				return 1;
			if (this.Price < obj.Price)
				return -1;
			else return 0;


		}

	}
}