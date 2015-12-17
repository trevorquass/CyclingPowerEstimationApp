using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingPowerEstimation.Units
{
    public struct Angle
    {
        public static readonly Angle Zero = new Angle(0.0);
        public static readonly Angle Unknown = new Angle(double.NaN);

        private double radians;

        public Angle(double angleInRadians)
        {
            this.radians = angleInRadians;
        }

        public double Radians
        {
            get
            {
                return this.radians;
            }

            set
            {
                this.radians = value;
            }
        }

        public bool IsUnknown
        {
            get
            {
                return double.IsNaN(this.Radians);
            }
        }

        public double Degrees
        {
            get
            {
                return (this.Radians * 180.0) / Math.PI;
            }
        }

        public static Angle FromDegrees(double angleInDegrees)
        {
            return new Angle(Math.PI * angleInDegrees / 180.0);
        }

        public static implicit operator double(Angle angle)
        {
            return angle.Radians;
        }

        public static Angle operator +(Angle angle1, Angle angle2)
        {
            return new Angle(angle1.Radians + angle2.Radians);
        }
        public static Angle operator -(Angle angle1, Angle angle2)
        {
            return new Angle(angle1.Radians - angle2.Radians);
        }
        public static Angle operator /(Angle angle, double divisor)
        {
            return new Angle(angle.Radians / divisor);
        }
    }
}
