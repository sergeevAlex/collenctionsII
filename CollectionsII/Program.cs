using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegation
{
	class Program
	{
		static void Main(string[] args)
		{

		
			// подключение List
			// Машины
			List<Car> lcar = new List<Car>();
			lcar.Add(new Car(prise: 23000, maxspeed: 240, year: 2009, Power: 331));
			lcar.Add(new Car(prise: 24000, maxspeed: 260, year: 2010, Power: 391));
			lcar.Add(new Car(prise: 22700, maxspeed: 250, year: 2008, Power: 381));
			lcar.Add(new Car(prise: 25000, maxspeed: 235, year: 2004, Power: 351));
			Console.WriteLine("Каталог автомобилей: \n");
			foreach (Car a in lcar)
				Console.WriteLine(a);
			lcar.Sort();
			Console.WriteLine("Автомобили упорядочены по цене: \n");
			foreach (Car a in lcar)
				Console.WriteLine(a);
			Console.ReadLine();


			// Самолет    
			List<Plane> lplane = new List<Plane>();
			lplane.Add(new Plane(prise: 55, maxspeed: 210, year: 1981, height: 11850, passengers: 190));
			lplane.Add(new Plane(prise: 50, maxspeed: 200, year: 1980, height: 11700, passengers: 180));
			lplane.Add(new Plane(prise: 70, maxspeed: 225, year: 1984, height: 13000, passengers: 216));
			lplane.Add(new Plane(prise: 60, maxspeed: 215, year: 1982, height: 11900, passengers: 200));
			lplane.Add(new Plane(prise: 65, maxspeed: 220, year: 1983, height: 12000, passengers: 184));

			Console.WriteLine("Каталог самолетов: \n");
			foreach (Plane a in lplane)
				Console.WriteLine(a);
			lplane.Sort();
			Console.WriteLine("Самолеты упорядочены по количеству пассажиров: \n");
			foreach (Plane a in lplane)
				Console.WriteLine(a);
			Console.ReadLine();


			//Корабль
			List<Ship> lship = new List<Ship>();
			lship.Add(new Ship(prise: 75000, maxspeed: 250, year: 2009, Port_registry: "Port X", passengers: 36));
			lship.Add(new Ship(prise:40000,maxspeed:250,year:2000,Port_registry:"Port I",passengers:25));
			lship.Add(new Ship(prise:50000,maxspeed:250,year:2005,Port_registry:"Port III",passengers:29));
			lship.Add(new Ship(prise:55000,maxspeed:250,year:2006,Port_registry:"Port V",passengers:30));
			lship.Add(new Ship(prise: 45000, maxspeed: 250, year: 2001, Port_registry: "Port II", passengers: 28));
			lship.Add(new Ship(prise:60000,maxspeed:250,year:2008,Port_registry:"Port VI",passengers:35));


			Console.WriteLine("Каталог кораблей: \n");
			foreach (Ship a in lship)
				Console.WriteLine(a);
			lship.Sort();
			Console.WriteLine("Корабли упорядочены по году выпуска: \n");
			foreach (Ship a in lship)
				Console.WriteLine(a);
			Console.ReadLine();

		}
	}
}