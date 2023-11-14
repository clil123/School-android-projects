using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class StuntBike : Bicycle
    {
        private bool forRaces;
        private double jumpHight;
        public StuntBike(string color, int maxSpeed, double sumMileage, bool forRaces, double jumpHight) :
            base(color, maxSpeed, sumMileage)
        {
            this.forRaces = forRaces;
            this.jumpHight = jumpHight;
        }
        
        public StuntBike(Bicycle b1, bool forRaces, double jumpHight) : base(b1.getColor(), b1.getMaxSpeed(), b1.getSumMileage())
        {
            this.forRaces = forRaces;
            this.jumpHight = jumpHight;
        }

        public void Jump(double hight)
        {
            Console.WriteLine("jummping!\n");
        }

        public override string ToString()
        {
            return base.ToString()+ string.Format(", for races: {0}, jump higjt: {1}",forRaces,jumpHight);
        }

        public bool getForRaces()
        {
            return this.forRaces;
        }

        public double getJumpHight()
        {
            return this.jumpHight;
        }
    }
}
