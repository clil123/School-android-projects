using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FrozenMountainBikes : MountainBikes
    {
        private int gear;
        public FrozenMountainBikes(string color, int maxSpeed, double sumMileage, bool inHighGear, int maxHight, int gear) :
            base(color, maxSpeed, sumMileage,inHighGear,maxHight)
        {
            this.gear = gear;
        }

        public FrozenMountainBikes(MountainBikes mb1, int gear) : 
            base(mb1.getColor(), mb1.getMaxSpeed(), mb1.getSumMileage(), mb1.getInHighGear(), mb1.getMaxHight())
        {
            this.gear = gear;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", gear: {0}", gear);
        }

        public int getGear()
        {
            return this.gear;
        }
    }
}
