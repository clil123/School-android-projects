using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Bicycle b1 = new Bicycle("red", 1, 42.3);
            Console.WriteLine(b1);

            //(Bicycle b1, bool forRaces, double jumpHight
            StuntBike sb1 = new StuntBike(b1,false,2.1);
            Console.WriteLine(sb1);

            //(Bicycle b1, string dateOfLastTreatment)
            RaceBike rb1 = new RaceBike(b1,"14.11.23");
            Console.WriteLine(rb1);

            //(Bicycle b1, int maxHight, bool inHighGear)
            MountainBikes mb1 = new MountainBikes(b1,100,true);
            Console.WriteLine(mb1);

            //(MountainBikes mb1, int gear)
            FrozenMountainBikes fmb1 = new FrozenMountainBikes(mb1, 3);
            Console.WriteLine(fmb1);

            Console.ReadKey();
        }
    }
}
