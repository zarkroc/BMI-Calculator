using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators
{
    /// <summary>
    /// Tomas Perers
    /// 2017-10-06
    /// GUI class and methods to validate the input and methods to perorm actions.
    /// </summary>
    public partial class MainForm : Form
    {
        // Calculation objects that will be used.
        private FuelCalculator fuelCalculator = new FuelCalculator();
        private BodyMassIndex bmiCalc = new BodyMassIndex();
        private CalorieCalculator calorieCalculator = new CalorieCalculator();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Reads and validate the input by the user for current odometer
        /// and calls a method to set the current odometer value
        /// </summary>
        /// <returns>bool true on valid input</returns>
        private bool ReadCurrentOdometer()
        {
            if (double.TryParse(txtCurrentOdometer.Text, out double value))
            {
                if (value > 0)
                {
                    fuelCalculator.SetCurrentReading(value);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        /// <summary>
        /// Reads and validate the input by the user for previous odometer
        /// and calls a method to set the previous odometer value
        /// </summary>
        /// <returns>bool true on valid input</returns>
        private bool ReadPreviousOdometer()
        {
            if (double.TryParse(txtPreviousOdometer.Text, out double value))
            {
                if (value >= 0)
                {
                    fuelCalculator.SetPreviousReading(value);
                    return true;
                }
                else
                return false;
            }
            else
                return false;
        }

        /// <summary>
        /// Read and validate the fuel ammount input made by the user.
        /// and calls a method to set the fule ammount
        /// </summary>
        /// <returns>bool true if valid</returns>
        private bool ReadFuelAmmount()
        {
            if (double.TryParse(txtFuelAmmount.Text, out double value))
            {
                if (value > 0)
                {
                    fuelCalculator.SetFuelAmmount(value);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        /// <summary>
        /// Reads and validates the input by the user for fuel price
        /// and calls a method to set the price
        /// </summary>
        /// <returns></returns>
        private bool ReadFuelPrice()
        {
            if (double.TryParse(txtFuelPrice.Text, out double value))
            {
                if (value > 0)
                {
                    fuelCalculator.SetUnitPrice(value);
                    return true;
                }
                return false;
            }
            else
                return false;
        }

        /// <summary>
        /// Read and validates the name and if valid sets the name of the result group box.
        /// </summary>
        /// <returns>bool true on valid input.</returns>
        private bool ReadName()
        {
            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
                return false;
            }
            else
            {
                grpBMIResult.Text = "Results for " + txtName.Text.Trim();
                return true;
            }
        }

        /// <summary>
        /// Read and validates the Height and calls a method to set the height.
        /// </summary>
        /// <returns>bool on sucess</returns>
        private bool ReadHeigt()
        {
            if (int.TryParse(txtHeight.Text, out int value))
            {
                if (value > 0)
                {
                    bmiCalc.SetHeight(value);
                    calorieCalculator.SetHeight(value);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        /// <summary>
        /// Read and validates the wight and calls a method to set the height.
        /// </summary>
        /// <returns>bool on sucess</returns>
        private bool ReadWeight()
        {
            if (int.TryParse(txtWeight.Text, out int value))
            {
                if (value > 0)
                {
                    bmiCalc.SetWeight(value);
                    calorieCalculator.SetWeight(value);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }

        /// <summary>
        /// Reads and validates age and calls method to set age.
        /// </summary>
        /// <returns>bool true on sucess</returns>
        private bool ReadAge()
        {
            if (int.TryParse(txtAge.Text, out int value))
            {
                if (value > 0)
                {
                    calorieCalculator.SetAge(value);
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
        }
        /// <summary>
        /// Calls the read methods and calls functions to perform the calculations 
        /// And updates the result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateFuel_Click(object sender, EventArgs e)
        {
            if (!ReadCurrentOdometer())
                PrintErrorMessage("Current Odometer has faulty input");
            else if (!ReadPreviousOdometer())
                PrintErrorMessage("Previous Odometer has faulty input");
            else if (!ReadFuelAmmount())
                PrintErrorMessage("Fuel ammount has faulty input");
            else if (!ReadFuelPrice())
                PrintErrorMessage("Fuel price has faulty input");
            else
            {
                lblResulFuelConsumptionKmPerL.Text = fuelCalculator.CalcConsumptionKilometerPerLiter().ToString("N2");
                lblResultFuelConsumptionLPerKm.Text = fuelCalculator.CalcFuelConsumtionPerKm().ToString("N2");
                lblResultFuelConsumptionLPerMile.Text = fuelCalculator.CalcConsumptionPerMetricMile().ToString("N2");
                lblResultFuelConsumptionLperSweMile.Text = fuelCalculator.CalcConsumptionPerSweMil().ToString("N2");
                lblResultCostPerKm.Text = fuelCalculator.CalcCostPerKm().ToString("N2");
            }
        }
        /// <summary>
        /// Prints and an error message.
        /// </summary>
        /// <param name="message">String with error message.</param>
        private void PrintErrorMessage(string message)
        {
            MessageBox.Show(message);
        }

        /// <summary>
        /// Calls the read methods and calls functions to perform the calculations 
        /// And updates the result.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            if (!ReadName())
                PrintErrorMessage("Check input for name");
            else if (!ReadHeigt())
                PrintErrorMessage("Check input for height");
            else if (!ReadWeight())
                PrintErrorMessage("Check input for weight");
            else
            {
                if (rbtnMetric.Checked)
                {
                    bmiCalc.setIsMetricChecked(true);
                }
                else if (rbtnUscs.Checked)
                {
                    bmiCalc.setIsMetricChecked(false);
                }
                bmiCalc.CalcBMI();
                lblResultBMI.Text = bmiCalc.GetBMI().ToString("N2");
                lblResultWeightCategory.Text = bmiCalc.CalcBMICategory();
            }
            
        }

        /// <summary>
        /// Clears input and output fields.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            InitializeGUI();
        }

        /// <summary>
        /// Validates the input and starts calucation of BMR and updates the output field.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculateBMR_Click(object sender, EventArgs e)
        {
            if (!ReadHeigt())
                PrintErrorMessage("Check input for height");
            else if (!ReadWeight())
                PrintErrorMessage("Check input for weight");
            else if (!ReadAge())
                PrintErrorMessage("Check input for age");
            else
            {
                if (rbtnFemale.Checked)
                    calorieCalculator.SetIsFemale(true);
                else if (!rbtnFemale.Checked)
                    calorieCalculator.SetIsFemale(false);

                calorieCalculator.CalculateBMR();

                if (rbtnSedentary.Checked)
                    calorieCalculator.SetActiveLevel("Sedantary");
                else if (rbtnLightlyActive.Checked)
                    calorieCalculator.SetActiveLevel("Lighly active");
                else if (rbtnModeratlyActive.Checked)
                    calorieCalculator.SetActiveLevel("Moderatley active");
                else if (rbtnVeryActive.Checked)
                    calorieCalculator.SetActiveLevel("Very active");
                else
                    calorieCalculator.SetActiveLevel("Extra active");


                lstBMRResult.Items.Add("BMR Result for " + txtName.Text.Trim());
                lstBMRResult.Items.Add("");
                lstBMRResult.Items.Add(String.Format("{0,-40} {1,10:N2}",
                    "Your BMR (calories/day)",
                    calorieCalculator.GetBMR()));
                lstBMRResult.Items.Add(String.Format("{0,-40} {1,10:N2}",
                    "Calories to maintain your weight",
                    calorieCalculator.MaintainWeightCalories()));
                lstBMRResult.Items.Add(String.Format("{0,-40} {1,10:N2}",
                    "Calories to loose 0,5 kg per week",
                    calorieCalculator.CalculateLossOrGain(-500.0)));
                lstBMRResult.Items.Add(String.Format("{0,-40} {1,10:N2}",
                    "Calories to loose 1 kg per week",
                    calorieCalculator.CalculateLossOrGain(-1000.0)));
                lstBMRResult.Items.Add(String.Format("{0,-40} {1,10:N2}",
                    "Calories to gain 0,5 kg per week",
                    calorieCalculator.CalculateLossOrGain(500.0)));
                lstBMRResult.Items.Add(String.Format("{0,-40} {1,10:N2}",
                    "Calories to gain 1 kg per week",
                    calorieCalculator.CalculateLossOrGain(1000.0)));
                lstBMRResult.Items.Add("");
                lstBMRResult.Items.Add("Loosing more then 1000 calories per day is to be avoided.");
            }
            

        }

        /// <summary>
        /// Change text depending on what radi button is activated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnMetric_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight.Text = "Height (cm)";
            lblWeight.Text = "Weight (kg)";
        }

        /// <summary>
        /// Change text depending on what radi button is activated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnUscs_CheckedChanged(object sender, EventArgs e)
        {
            lblHeight.Text = "Height (inch)";
            lblWeight.Text = "Weight (pund)";
        }

        /// <summary>
        /// Sets default values in output and input labels /text boxes etc.
        /// </summary>
        private void InitializeGUI()
        {
            lstBMRResult.Text = "";
            lblResulFuelConsumptionKmPerL.Text = "";
            lblResultBMI.Text = "";
            lblResultCostPerKm.Text = "";
            lblResultFuelConsumptionLPerKm.Text = "";
            lblResultFuelConsumptionLPerMile.Text = "";
            lblResultFuelConsumptionLperSweMile.Text = "";
            lblResultWeightCategory.Text = "";
            rbtnFemale.Checked = true;
            rbtnMetric.Checked = true;
            txtAge.Text = "";
            txtCurrentOdometer.Text = "";
            txtFuelAmmount.Text = "";
            txtFuelPrice.Text = "";
            txtHeight.Text = "";
            txtName.Text = "";
            txtPreviousOdometer.Text = "";
            txtWeight.Text = "";
            lblSelectedItem.Text = "-1";
            lblBMIText.Text = "";
            lstBMRResult.Items.Clear();
        }

        /// <summary>
        /// Shows what item is selected in a list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstBMRResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectedItem.Text = lstBMRResult.SelectedIndex.ToString();
        }

        /// <summary>
        /// Unselect items in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnselect_Click(object sender, EventArgs e)
        {
            lblSelectedItem.Text = "-1";
            lstBMRResult.ClearSelected();
        }
    }
}
