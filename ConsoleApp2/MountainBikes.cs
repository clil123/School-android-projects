using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class MountainBikes : Bicycle
    {
        private int maxHight;
        private bool inHighGear;
        public MountainBikes(string color, int maxSpeed, double sumMileage, bool inHighGear, int maxHight) :
            base(color, maxSpeed, sumMileage)
        {
            this.inHighGear = inHighGear;
            this.maxHight = maxHight;
        }

        public MountainBikes(Bicycle b1, int maxHight, bool inHighGear) : base(b1.getColor(), b1.getMaxSpeed(), b1.getSumMileage())
        {
            this.inHighGear = inHighGear;
            this.maxHight = maxHight;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", max hight: {0}, in high gear?: {1}", maxHight, inHighGear);
        }

        public bool getInHighGear()
        {
            return this.inHighGear;
        }

        public int getMaxHight()
        {
            return this.maxHight;
        }
    }
}
