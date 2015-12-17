using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingPowerEstimation.Units
{
    public struct Acceleration
    {
        public static readonly Acceleration Zero = new Acceleration(0.0);
        public static readonly Acceleration Gravity = new Acceleration(9.80665);
        public static readonly Acceleration Unknown = new Acceleration(double.NaN);

        private double metersPerSecondPerSecond;

        public Acceleration(double accelerationInMetersPerSecondPerSecond)
        {
            this.metersPerSecondPerSecond = accelerationInMetersPerSecondPerSecond;
        }

        public double MetersPerSecondPerSecond
        {
            get
            {
                return this.metersPerSecondPerSecond;
            }

            set
            {
                this.metersPerSecondPerSecond = value;
            }
        }

        public bool IsUnknown
        {
            get
            {
                return double.IsNaN(this.MetersPerSecondPerSecond);
            }
        }

        public static implicit operator double(Acceleration distance)
        {
            return distance.MetersPerSecondPerSecond;
        }

        public static Acceleration operator +(Acceleration acceleration1, Acceleration acceleration2)
        {
            return new Acceleration(acceleration1.MetersPerSecondPerSecond + acceleration2.MetersPerSecondPerSecond);
        }
        public static Acceleration operator -(Acceleration acceleration1, Acceleration acceleration2)
        {
            return new Acceleration(acceleration1.MetersPerSecondPerSecond - acceleration2.MetersPerSecondPerSecond);
        }
        public static Acceleration operator /(Acceleration distance, double divisor)
        {
            return new Acceleration(distance.MetersPerSecondPerSecond / divisor);
        }
    }
}
