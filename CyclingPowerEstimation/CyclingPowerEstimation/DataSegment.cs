using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyclingPowerEstimation.Units;

namespace CyclingPowerEstimation
{
    public class DataSegment
    {
        public DataSegment(DataPoint start, DataPoint end)
        {
            this.Start = start;
            this.End = end;
            this.WindForce = Force.Zero;
            this.AccelerationForce = Force.Zero;
            this.HillForce = Force.Zero;
            this.RollingResistanceForce = Force.Zero;
        }

        public DataPoint Start { get; private set; }
        public DataPoint End { get; private set; }

        public Distance Length
        {
            get
            {
                return new Distance(Math.Abs(this.Start.DistanceToPoint(this.End).Meters));
            }
        }

        public double Gradient
        {
            get
            {
                return this.Start.GradientToPoint(this.End);
            }
        }

        public TimeSpan ElapsedTime
        {
            get
            {
                return new TimeSpan(this.End.DateTime.Ticks - this.Start.DateTime.Ticks);
            }
        }

        public Speed Speed
        {
            get
            {
                if (this.Start.Speed.IsUnknown || this.End.Speed.IsUnknown)
                {
                    if (this.Length <= Distance.Zero || this.ElapsedTime <= TimeSpan.Zero)
                    {
                        return Speed.Zero;
                    }

                    return this.Length / this.ElapsedTime;
                }
                return (this.Start.Speed + this.End.Speed) / 2.0;
            }
        }

        public Angle Latitude
        {
            get
            {
                if (this.Start.Latitude.IsUnknown || this.End.Latitude.IsUnknown)
                {
                    return Angle.Unknown;
                }
                return (this.Start.Latitude + this.End.Latitude) / 2.0;
            }
        }

        public Angle Longitude
        {
            get
            {
                if (this.Start.Longitude.IsUnknown || this.End.Longitude.IsUnknown)
                {
                    return Angle.Unknown;
                }
                return (this.Start.Longitude + this.End.Longitude) / 2.0;
            }
        }

        public Distance Altitude
        {
            get
            {
                if (this.Start.Altitude.IsUnknown || this.End.Altitude.IsUnknown)
                {
                    return Distance.Unknown;
                }
                return (this.Start.Altitude + this.End.Altitude) / 2.0;
            }
        }

        public Frequency Cadence
        {
            get
            {
                if (this.Start.Cadence.IsUnknown)
                {
                    if (this.End.Cadence.IsUnknown)
                    {
                        return Frequency.Unknown;
                    }
                    return this.End.Cadence;
                }

                if (this.End.Cadence.IsUnknown)
                {
                    return this.Start.Cadence;
                }
                return (this.Start.Cadence + this.End.Cadence) / 2.0;
            }
        }

        public Frequency HeartRate
        {
            get
            {
                if (this.Start.HeartRate.IsUnknown)
                {
                    if (this.End.HeartRate.IsUnknown)
                    {
                        return Frequency.Unknown;
                    }
                    return this.End.HeartRate;
                }

                if (this.End.HeartRate.IsUnknown)
                {
                    return this.Start.HeartRate;
                }
                return (this.Start.HeartRate + this.End.HeartRate) / 2.0;
            }
        }

        public Acceleration Acceleration
        {
            get
            {
                if (this.Start.Speed.IsUnknown || this.End.Speed.IsUnknown)
                {
                    return Acceleration.Zero;
                }
                return (this.End.Speed - this.Start.Speed) / this.ElapsedTime;
            }
        }

        public Force RollingResistanceForce { get; private set; }
        public Force AccelerationForce { get; private set; }
        public Force HillForce { get; private set; }
        public Force WindForce { get; private set; }

        public Force TotalForce
        {
            get
            {
                return new Force(Math.Max(0.0, this.WindForce + this.AccelerationForce + this.HillForce + this.RollingResistanceForce));
            }
        }

        public Power Power
        {
            get
            {
                return this.TotalForce * this.Speed;
            }
        }

        public void Calculate(Rider rider, Reality reality)
        {
            this.RollingResistanceForce = this.GetRollingResistanceForce(rider, reality);
            this.AccelerationForce = this.GetAccelerationForce(rider);
            this.HillForce = this.GetHillForce(rider);
            this.WindForce = this.GetWindForce(reality);
        }

        private Force GetRollingResistanceForce(Rider rider, Reality reality)
        {
            return new Force(rider.MassIncludingBike * Acceleration.Gravity * reality.CoefficientOfRollingResistance);
        }

        private Force GetAccelerationForce(Rider rider)
        {
            return new Force(rider.MassIncludingBike * this.Acceleration);
        }

        private Force GetHillForce(Rider rider)
        {
            return new Force(rider.MassIncludingBike * Acceleration.Gravity * this.Gradient);
        }

        private Force GetWindForce(Reality reality)
        {
            return new Force(0.5 * reality.EffectiveFrontalArea * reality.DragCoefficient * reality.AirDensity(this.End.Altitude) * (this.Speed.MetersPerSecond * this.Speed.MetersPerSecond));
        }
    }
}
