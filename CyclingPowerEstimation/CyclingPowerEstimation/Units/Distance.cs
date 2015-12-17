using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingPowerEstimation.Units
{
    public struct Distance
    {
        public static readonly Distance Zero = new Distance(0.0);
        public static readonly Distance Unknown = new Distance(double.NaN);

        private double meters;

        public Distance(double distanceInMeters)
        {
            this.meters = distanceInMeters;
        }

        public double Meters
        {
            get
            {
                return this.meters;
            }

            set
            {
                this.meters = value;
            }
        }

        public bool IsUnknown
        {
            get
            {
                return double.IsNaN(this.Meters);
            }
        }

        public double Kilometers
        {
            get
            {
                return this.Meters / 1000.0;
            }
        }

        public double Miles
        {
            get
            {
                return this.Meters * 0.000621371192;
            }
        }

        public static implicit operator double(Distance distance)
        {
            return distance.Meters;
        }

        public static Distance operator +(Distance distance1, Distance distance2)
        {
            return new Distance(distance1.Meters + distance2.Meters);
        }
        public static Distance operator -(Distance distance1, Distance distance2)
        {
            return new Distance(distance1.Meters - distance2.Meters);
        }
        public static Distance operator /(Distance distance, double divisor)
        {
            return new Distance(distance.Meters / divisor);
        }
        public static Speed operator /(Distance distance, TimeSpan divisor)
        {
            return new Speed(distance.Meters / divisor.TotalSeconds);
        }
    }
}
