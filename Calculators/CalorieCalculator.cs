using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    class CalorieCalculator
    {
        private int weight, height, age;
        private double BMR;
        private double activeLevelFactor;
        private bool isFemaleChecked;
        private const double BMROffsetFemale = 161;
        private const double BMROffsetMale = 5;

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
        /// Set the age
        /// </summary>
        /// <param name="age">int age</param>
        public void SetAge(int age)
        {
            this.age = age;
        }

        /// <summary>
        /// Set the isFemaleChecked 
        /// </summary>
        /// <param name="isFemale"></param>
        public void SetIsFemale(bool isFemale)
        {
            this.isFemaleChecked = isFemale;
        }

        /// <summary>
        /// Set the activite level.
        /// </summary>
        /// <param name="activeLevel"></param>
        public void SetActiveLevel(string activeLevel)
        {
            if (activeLevel == "Sedantary")
                activeLevelFactor = 1.2;
            else if (activeLevel == "Lighly active")
                activeLevelFactor = 1.375;
            else if (activeLevel == "Moderatley active")
                activeLevelFactor = 1.550;
            else if (activeLevel == "Very active")
                activeLevelFactor = 1.725;
            else if (activeLevel == "Extra active")
                activeLevelFactor = 1.9;
            else
                activeLevelFactor = 0;
        }


        /// <summary>
        /// Calculates BMR
        /// </summary>
        public void CalculateBMR()
        {
            BMR = 10 * weight + 6.25 * height - 5 * age;
            if (isFemaleChecked)
                BMR -= BMROffsetFemale;
            else
                BMR += BMROffsetMale;
        }

        /// <summary>
        /// Returns the BMR
        /// </summary>
        /// <returns>double BMR</returns>
        public double GetBMR()
        {
            return this.BMR;
        }

        /// <summary>
        /// Calculates the calories needed to maintain weight
        /// </summary>
        /// <returns>double BMR * activeLevelFactor</returns>
        public double MaintainWeightCalories()
        {
            return BMR * activeLevelFactor;
        }

        /// <summary>
        /// Calculates the calories needed to loose or gain weight
        /// </summary>
        /// <param name="wantToLooseorGain">weight loose/gain</param>
        /// <returns>double calories</returns>
        public double CalculateLossOrGain(double wantToLooseorGain)
        {
            
            return MaintainWeightCalories() + wantToLooseorGain;
            
        }
    }
}
