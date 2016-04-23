using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegation
{
	class Plane : Vehicle, IComparable<Plane>
	{
		public int height { get; set; }
		public int passengers { get; set; }
		public Plane(int prise, int maxspeed, int year, int height, int passengers)
			: base(prise, maxspeed, year)
		{
			this.height = height;
			this.passengers = passengers;
		}

		public override string ToString()
		{
			return String.Format("Цена: {0}\tМаксимальная скорость: {1}\tГод выпуска: {2}\tПассажиров: {3}",
				this.Price, this.maxspeed, this.year, this.passengers);
		}

		public int CompareTo(Plane obj)
		{
			if (this.passengers > obj.passengers)
				return 1;
			if (this.passengers < obj.passengers)
				return -1;
			else return 0;


		}

	}
}