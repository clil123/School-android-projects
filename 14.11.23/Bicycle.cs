using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Bicycle
    {
        private string color;
        private int maxSpeed;
        private double sumMileage;

        public Bicycle(string color, int maxSpeed, double sumMileage)
        {
            this.color = color;
            this.maxSpeed = maxSpeed;
            this.sumMileage = sumMileage;
        }

        public Bicycle(Bicycle b1)
        {
            this.color = b1.getColor();
            this.maxSpeed = b1.getMaxSpeed();
            this.sumMileage = b1.getSumMileage();
        }

        public void Ride(double distance)
        {
            Console.WriteLine("riding!\n");
        }

        public override string ToString()
        {
            return string.Format("color: {0}, max speed: {1}, sum mileage: {2}", color, maxSpeed, sumMileage);
        }

        public string getColor()
        {
            return this.color;
        }

        public int getMaxSpeed()
        {
            return this.maxSpeed;
        }
        public double getSumMileage()
        {
            return this.sumMileage;
        }
    }
}
