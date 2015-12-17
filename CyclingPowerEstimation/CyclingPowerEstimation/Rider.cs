using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingPowerEstimation
{
    public class Rider
    {
        public Rider(double massInKg, double bikeMassInKg)
        {
            this.Mass = massInKg;
            this.BikeMass = bikeMassInKg;
        }

        public double Mass { get; private set; }

        public double BikeMass { get; private set; }

        public double MassIncludingBike
        {
            get
            {
                return this.Mass + this.BikeMass;
            }
        }
    }
}
