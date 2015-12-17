using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingPowerEstimation.Units
{
    public struct Speed
    {
        public static readonly Speed Zero = new Speed(0.0);
        public static readonly Speed Unknown = new Speed(double.NaN);

        private double metersPerSecond;

        public Speed(double speedInMetersPerSecond)
        {
            this.metersPerSecond = speedInMetersPerSecond;
        }

        public double MetersPerSecond
        {
            get
            {
                return this.metersPerSecond;
            }

            set
            {
                this.metersPerSecond = value;
            }
        }

        public bool IsUnknown
        {
            get
            {
                return double.IsNaN(this.MetersPerSecond);
            }
        }

        public double KilometersPerHour
        {
            get
            {
                return this.MetersPerSecond * 3.6;
            }
        }

        public static implicit operator double(Speed speed)
        {
            return speed.MetersPerSecond;
        }

        public static Speed operator +(Speed speed1, Speed speed2)
        {
            return new Speed(speed1.MetersPerSecond + speed2.MetersPerSecond);
        }
        public static Speed operator -(Speed speed1, Speed speed2)
        {
            return new Speed(speed1.MetersPerSecond - speed2.MetersPerSecond);
        }
        public static Speed operator /(Speed speed, double divisor)
        {
            return new Speed(speed.MetersPerSecond / divisor);
        }
        public static Acceleration operator /(Speed speed, TimeSpan timeSpan)
        {
            return new Acceleration(speed.MetersPerSecond / timeSpan.TotalSeconds);
        }
    }
}
