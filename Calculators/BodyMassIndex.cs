using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    class BodyMassIndex
    {
        private int height, weight;
        private bool isMetricChecked;
        private double BMI;
        private const double metricConversion = 703.0;
        private const double convertToMeter = 0.01;

        /// <summary>
        /// Returns the BMI
        /// </summary>
        /// <returns>double BMI</returns>
        public double GetBMI()
        {
            return this.BMI;
        }

        /// <summary>
        /// Sets the height
        /// </summary>
        /// <param name="height">int height</param>
        public void SetHeight(int height)
        {
            this.height = height;
        }

        /// <summary>
        /// Sets the weight
        /// </summary>
        /// <param name="weight">int weight</param>
        public void SetWeight(int weight)
        {
            this.weight = weight;
        }

        /// <summary>
        /// Calculates the BMI
        /// </summary>
        /// <returns>double BMI</returns>
        public void CalcBMI()
        {
            if (isMetricChecked)
            {
                this.BMI =  this.weight / ((this.height * convertToMeter) * (this.height * convertToMeter));
            }
            else
                this.BMI =  metricConversion * this.weight / (this.height * this.height);
        }

        /// <summary>
        /// Returns the category for each BMI class.
        /// </summary>
        /// <returns>string with BMI category</returns>
        public string CalcBMICategory()
        {
            if (BMI < 18.5)
                return "underweight";
            else if (BMI < 25)
                return "Normal weight";
            else if (BMI < 30)
                return "Overweight";
            else if (BMI < 35)
                return "Obesity class I";
            else if (BMI < 40)
                return "Obesity class II";
            else 
                return "Obesity class III";
        }

        /// <summary>
        /// Sets isMetricChecked.
        /// </summary>
        /// <param name="isMetricChecked">bool sent from caller</param>
        public void setIsMetricChecked(bool isMetricChecked)
        {
            this.isMetricChecked = isMetricChecked;
        }
    }
}
