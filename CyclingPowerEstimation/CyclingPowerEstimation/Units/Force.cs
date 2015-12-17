using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingPowerEstimation.Units
{
    public struct Force
    {
        public static readonly Force Zero = new Force(0.0);
        public static readonly Force Unknown = new Force(double.NaN);

        private double newtons;

        public Force(double forceInNewtons)
        {
            this.newtons = forceInNewtons;
        }

        public double Newtons
        {
            get
            {
                return this.newtons;
            }

            set
            {
                this.newtons = value;
            }
        }

        public bool IsUnknown
        {
            get
            {
                return double.IsNaN(this.Newtons);
            }
        }

        public static implicit operator double(Force force)
        {
            return force.Newtons;
        }

        public static Force operator +(Force force1, Force force2)
        {
            return new Force(force1.Newtons + force2.Newtons);
        }
        public static Force operator -(Force force1, Force force2)
        {
            return new Force(force1.Newtons - force2.Newtons);
        }
        public static Force operator /(Force force, double divisor)
        {
            return new Force(force.Newtons / divisor);
        }
        public static Power operator *(Force force, Speed speed)
        {
            return new Power(force.Newtons * speed.MetersPerSecond);
        }
    }
}
