using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingPowerEstimation.Units
{
    public struct Power
    {
        public static readonly Power Zero = new Power(0.0);
        public static readonly Power Unknown = new Power(double.NaN);

        private double watts;

        public Power(double powerInWatts)
        {
            this.watts = powerInWatts;
        }

        public double Watts
        {
            get
            {
                return this.watts;
            }

            set
            {
                this.watts = value;
            }
        }

        public static implicit operator double(Power power)
        {
            return power.Watts;
        }

        public static Power operator +(Power power1, Power power2)
        {
            return new Power(power1.Watts + power2.Watts);
        }
        public static Power operator -(Power power1, Power power2)
        {
            return new Power(power1.Watts - power2.Watts);
        }
        public static Power operator /(Power power, double divisor)
        {
            return new Power(power.Watts / divisor);
        }
    }
}
