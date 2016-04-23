using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegation
{
	class Ship : Vehicle, IComparable<Ship>
	{
		public string Port_registry { get; set; }
		public int passengers { get; set; }
		public Ship(int prise, int maxspeed, int year, string Port_registry, int passengers) : base(prise, maxspeed, year)
		{
			this.Port_registry = Port_registry;
			this.passengers = passengers;
		}   
		public int CompareTo(Ship obj)
		{
			if (this.year > obj.year)
				return 1;
			if (this.year < obj.year)
				return -1;
			else return 0;
		}

		public override string ToString()
		{
			return String.Format("Цена: {0}\tМаксимальная скорость: {1}\tГод выпуска: {2}\tПорт приписки: {3}\tКоличество пассажиров:{4}",
				this.Price, this.maxspeed, this.year, this.Port_registry, this.passengers);
		}



	}
}