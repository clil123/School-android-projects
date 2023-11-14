using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class RaceBike : Bicycle
    {
        private string dateOfLastTreatment;
        public RaceBike(string color, int maxSpeed, double sumMileage, string dateOfLastTreatment) :
            base(color, maxSpeed, sumMileage)
        {
            this.dateOfLastTreatment = dateOfLastTreatment;
        }

        public RaceBike(Bicycle b1, string dateOfLastTreatment) : base(b1.getColor(), b1.getMaxSpeed(), b1.getSumMileage())
        {
            this.dateOfLastTreatment = dateOfLastTreatment;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", date of last treatment: {0}", dateOfLastTreatment);
        }

        public string getDateOfLastTreatment()
        {
            return this.dateOfLastTreatment;
        }
    }
}
