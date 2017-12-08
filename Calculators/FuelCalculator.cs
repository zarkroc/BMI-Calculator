using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    class FuelCalculator
    {
        private double currReading, fuelAmount, prevReading, unitPrice;
        private const double KmToMileFactor = 0.621371192;

        /// <summary>
        /// How many kilometers the car be driven for a liter?
        /// kmPerLit =  km/fuel amount 
        /// </summary>
        /// <returns>double distance / fuelAmmount</returns>
        public double CalcConsumptionKilometerPerLiter()
        {
            return (currReading - prevReading) / fuelAmount;
        }
        /// <summary>
        /// Calculates how many liters the car uses per Metric Mile
        /// </summary>
        /// <returns>double ((currReading - prevReading) / fuelAmount ) KmToMileFactor </returns>
        public double CalcConsumptionPerMetricMile()
        {
            return CalcFuelConsumtionPerKm() / KmToMileFactor;
        }
        /// <summary>
        /// Calculates the cost per Km
        /// </summary>
        /// <returns>double Liter Per Km * unit price</returns>
        public double CalcCostPerKm()
        {
            return CalcFuelConsumtionPerKm() * unitPrice;
        }
        /// <summary>
        /// Calculates how many liters the car uses per kilometer
        /// </summary>
        /// <returns>double result of fuelAmmount / distance </returns>
        public double CalcFuelConsumtionPerKm()
        {
            return fuelAmount / (currReading - prevReading);
        }
        /// <summary>
        /// Calculates how many liters the car uses per swedish mile
        /// </summary>
        /// <returns>double CalcFuelConsumtionPerKm() * 10;</returns>
        public double CalcConsumptionPerSweMil()
        {
            return CalcFuelConsumtionPerKm() * 10;
        }

        /// <summary>
        /// REturns the current reading of the Odeometer
        /// </summary>
        /// <returns>double distance traveled</returns>
        public double GetCurrentReadin()
        {
            return currReading;
        }

        /// <summary>
        /// Returns the price of fuel
        /// </summary>
        /// <returns>double fuel price</returns>
        public double GetUnitPrice()
        {
            return unitPrice;
        }
        /// <summary>
        /// Set current reading on Odometer
        /// </summary>
        /// <param name="currReading"></param>
        public void SetCurrentReading(double currReading)
        {
            this.currReading = currReading;
        }
        /// <summary>
        /// Set ammount of fuel
        /// </summary>
        /// <param name="fuelAmount"></param>
        public void SetFuelAmmount(double fuelAmount)
        {
            this.fuelAmount = fuelAmount;
        }
        /// <summary>
        /// Set the previous reading on odometer
        /// </summary>
        /// <param name="prevReading"></param>
        public void SetPreviousReading(double prevReading)
        {
            this.prevReading = prevReading;
        }

        /// <summary>
        /// Set the fuel price.
        /// </summary>
        /// <param name="unitPrice"></param>
        public void SetUnitPrice(double unitPrice)
        {
            this.unitPrice = unitPrice;
        }

        /// <summary>
        /// Validates the odometer values.
        /// If current odometer is smaller then previous or unitprice is negative or previous reading is less then 0 return false
        /// otherwise return true
        /// </summary>
        /// <returns>bool true or false depending on condition in summary.</returns>
        public bool ValidateOdometerValues()
        {
            if (currReading <= prevReading || unitPrice < 0 || prevReading < 0)
                return false;
            else
                return true;
        }
    }
}
