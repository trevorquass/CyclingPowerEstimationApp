using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyclingPowerEstimation.Units;
using System.Diagnostics.CodeAnalysis;

namespace CyclingPowerEstimation
{
    public class Reality
    {
        public const double SpeicificGasConstantDryAir = 287.05;
        public const double MolecularWeightOfDryAir = 0.0289644;
        public const double SpecificGasConstanthWaterVapor = 461.495;
        public const double AirDenistyDefault = 1.2466;
        public const double GasConstant = 8.31447;
        public const double TemperatureLapseRate = 0.0065;
        public const double SeaLevelStandardTemp = 288.15;
        public const double SeaLevelStandardPressure = 101325;

        private double coefficientOfRollingResistance = 0.0045;
        private double dragCoefficient = 0.5;
        private double effectiveFrontalArea = 0.399483;
        private double temperature = 15.0;

        public double CoefficientOfRollingResistance
        {
            get
            {
                return this.coefficientOfRollingResistance;
            }

            set
            {
                this.coefficientOfRollingResistance = value;
            }
        }

        public double DragCoefficient
        {
            get
            {
                return this.dragCoefficient;
            }

            set
            {
                this.dragCoefficient = value;
            }
        }

        public double EffectiveFrontalArea
        {
            get
            {
                return this.effectiveFrontalArea;
            }

            set
            {
                this.effectiveFrontalArea = value;
            }
        }

        public double Temperature
        {
            get
            {
                return this.temperature;
            }

            set
            {
                this.temperature = value;
            }
        }

        public double AirDensity(double altitude)
        {
            double density;
            density = (this.PressureAtAltitude(altitude) * MolecularWeightOfDryAir) / (GasConstant * this.CelsiusToKelvin(this.Temperature));
            return density;
        }

        public double PressureAtAltitude(double altitude)
        {
            double gM = Acceleration.Gravity * MolecularWeightOfDryAir;
            double RL = SpecificGasConstanthWaterVapor * TemperatureLapseRate;
            double gMOverRL = gM / RL;

            altitude = altitude / 1000.0;
            double LH = TemperatureLapseRate * altitude;
            double pressure = SeaLevelStandardPressure * Math.Pow(1.0 - (LH / SeaLevelStandardTemp), gMOverRL);
            return pressure;
        }

        private double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }
    }
}
