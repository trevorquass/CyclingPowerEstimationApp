using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyclingPowerEstimation.Units
{
    public struct Frequency
    {
        public static readonly Frequency Zero = new Frequency(0);
        public static readonly Frequency Unknown = new Frequency(int.MinValue);

        private int perMinute;

        public Frequency(int frequencyPerMinute)
        {
            this.perMinute = frequencyPerMinute;
        }

        public int PerMinute
        {
            get
            {
                return this.perMinute;
            }

            set
            {
                this.perMinute = value;
            }
        }

        public bool IsUnknown
        {
            get
            {
                return this.PerMinute == int.MinValue;
            }
        }

        public static implicit operator int(Frequency frequency)
        {
            return frequency.PerMinute;
        }

        public static Frequency operator +(Frequency frequency1, Frequency frequency2)
        {
            return new Frequency(frequency1.PerMinute + frequency2.PerMinute);
        }
        public static Frequency operator -(Frequency frequency1, Frequency frequency2)
        {
            return new Frequency(frequency1.PerMinute - frequency2.PerMinute);
        }
        public static Frequency operator /(Frequency frequency, double divisor)
        {
            return new Frequency((int)(frequency.PerMinute / divisor));
        }
    }
}
