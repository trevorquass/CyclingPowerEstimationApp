using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyclingPowerEstimation.Units;

namespace CyclingPowerEstimation
{
    public class DataPoint
    {
        public DataPoint(DateTimeOffset dateTime, Distance altitude, Frequency cadence, Distance totalDistance, Speed speed, Frequency heartRateInBpm, Angle latitude, Angle longitude)
        {
            this.DateTime = dateTime;
            this.Altitude = altitude;
            this.Cadence = cadence;
            this.TotalDistance = totalDistance;
            this.Speed = speed;
            this.HeartRate = heartRateInBpm;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        public Distance Altitude { get; private set; }
        public Frequency HeartRate { get; private set; }
        public Frequency Cadence { get; private set; }
        public Speed Speed { get; set; }
        public Distance TotalDistance { get; private set; }
        public DateTimeOffset DateTime { get; set; }
        public Angle Longitude { get; set; }
        public Angle Latitude { get; set; }

        public Distance DistanceToPoint(DataPoint otherPoint)
        {
            if (this.TotalDistance.IsUnknown || otherPoint.TotalDistance.IsUnknown)
            {
                var ascent = this.AscentToPoint(otherPoint);
                var haversine = this.HaversineDistanceToPoint(otherPoint);

                return new Distance(Math.Sqrt((ascent * ascent) + (haversine * haversine)));
            }
            return otherPoint.TotalDistance - this.TotalDistance;
        }

        public Distance AscentToPoint(DataPoint otherPoint)
        {
            return otherPoint.Altitude - this.Altitude;
        }

        public double GradientToPoint(DataPoint otherPoint)
        {
            double distance = this.HaversineDistanceToPoint(otherPoint);

            if ((Math.Abs(distance - 0.0) < 0.0001) || double.IsNaN(distance))
            {
                return 0.0;
            }
            return this.AscentToPoint(otherPoint) / distance;
        }

        public Distance HaversineDistanceToPoint(DataPoint otherPoint)
        {
            Distance result;

            if (otherPoint.Latitude.IsUnknown || otherPoint.Longitude.IsUnknown)
            {
                result = Distance.Zero;
            }
            else
            {
                var latitudeDelta = otherPoint.Latitude - this.Latitude;
                var longitudeDelta = otherPoint.Longitude - this.Longitude;

                var intermediateResult = (Math.Sin(latitudeDelta / 2.0) * Math.Sin(latitudeDelta / 2.0))
                        + (Math.Sin(longitudeDelta / 2.0) * Math.Sin(longitudeDelta / 2.0) * Math.Cos(this.Latitude)
                           * Math.Cos(otherPoint.Latitude));

                var radiusOfEarth = this.GetRadiusOfEarth(this.Latitude);

                var greatCircleDistanceInRadians = 2.0 * Math.Atan2(Math.Sqrt(intermediateResult), Math.Sqrt(1.0 - intermediateResult));

                result = new Distance(greatCircleDistanceInRadians * radiusOfEarth);
            }
            return result;
        }

        private Distance GetRadiusOfEarth(Angle latitude)
        {
            double averageRadiusOfEarth = 6378000.0;
            double equationConstant = 21000.0;
            return new Distance(averageRadiusOfEarth - (equationConstant * Math.Sin(latitude)));
        }
    }
}
