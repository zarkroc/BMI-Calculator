namespace Calculators
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpFuel = new System.Windows.Forms.GroupBox();
            this.txtFuelPrice = new System.Windows.Forms.TextBox();
            this.txtFuelAmmount = new System.Windows.Forms.TextBox();
            this.txtPreviousOdometer = new System.Windows.Forms.TextBox();
            this.txtCurrentOdometer = new System.Windows.Forms.TextBox();
            this.lblFuelPrice = new System.Windows.Forms.Label();
            this.lblAmmountOfFuel = new System.Windows.Forms.Label();
            this.lvlPreviousOdometer = new System.Windows.Forms.Label();
            this.lblCurrentOdometer = new System.Windows.Forms.Label();
            this.btnCalculateFuel = new System.Windows.Forms.Button();
            this.grpFuelResults = new System.Windows.Forms.GroupBox();
            this.lblCostPerKilometer = new System.Windows.Forms.Label();
            this.lblFuelConsumptionLperSweMile = new System.Windows.Forms.Label();
            this.lblFuelConsumptionLPerMile = new System.Windows.Forms.Label();
            this.lblFuelConsumptionLPerKm = new System.Windows.Forms.Label();
            this.lblFuelConsumptionKmPerL = new System.Windows.Forms.Label();
            this.lblResultCostPerKm = new System.Windows.Forms.Label();
            this.lblResultFuelConsumptionLperSweMile = new System.Windows.Forms.Label();
            this.lblResultFuelConsumptionLPerMile = new System.Windows.Forms.Label();
            this.lblResultFuelConsumptionLPerKm = new System.Windows.Forms.Label();
            this.lblResulFuelConsumptionKmPerL = new System.Windows.Forms.Label();
            this.grpBMI = new System.Windows.Forms.GroupBox();
            this.rbtnUscs = new System.Windows.Forms.RadioButton();
            this.rbtnMetric = new System.Windows.Forms.RadioButton();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.grpBMIResult = new System.Windows.Forms.GroupBox();
            this.lblWeightCatText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBMIText = new System.Windows.Forms.Label();
            this.lblResultWeightCategory = new System.Windows.Forms.Label();
            this.lblResultBMI = new System.Windows.Forms.Label();
            this.grpBMR = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lstBMRResult = new System.Windows.Forms.ListBox();
            this.lblSelectedItem = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.btnUnselect = new System.Windows.Forms.Button();
            this.btnCalculateBMR = new System.Windows.Forms.Button();
            this.grpActiveLevel = new System.Windows.Forms.GroupBox();
            this.rbtnExtraActive = new System.Windows.Forms.RadioButton();
            this.rbtnVeryActive = new System.Windows.Forms.RadioButton();
            this.rbtnModeratlyActive = new System.Windows.Forms.RadioButton();
            this.rbtnLightlyActive = new System.Windows.Forms.RadioButton();
            this.rbtnSedentary = new System.Windows.Forms.RadioButton();
            this.grpFuel.SuspendLayout();
            this.grpFuelResults.SuspendLayout();
            this.grpBMI.SuspendLayout();
            this.grpBMIResult.SuspendLayout();
            this.grpBMR.SuspendLayout();
            this.grpActiveLevel.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFuel
            // 
            this.grpFuel.Controls.Add(this.txtFuelPrice);
            this.grpFuel.Controls.Add(this.txtFuelAmmount);
            this.grpFuel.Controls.Add(this.txtPreviousOdometer);
            this.grpFuel.Controls.Add(this.txtCurrentOdometer);
            this.grpFuel.Controls.Add(this.lblFuelPrice);
            this.grpFuel.Controls.Add(this.lblAmmountOfFuel);
            this.grpFuel.Controls.Add(this.lvlPreviousOdometer);
            this.grpFuel.Controls.Add(this.lblCurrentOdometer);
            this.grpFuel.Controls.Add(this.btnCalculateFuel);
            this.grpFuel.Controls.Add(this.grpFuelResults);
            this.grpFuel.Location = new System.Drawing.Point(12, 12);
            this.grpFuel.Name = "grpFuel";
            this.grpFuel.Size = new System.Drawing.Size(426, 309);
            this.grpFuel.TabIndex = 0;
            this.grpFuel.TabStop = false;
            this.grpFuel.Text = "Fuel";
            // 
            // txtFuelPrice
            // 
            this.txtFuelPrice.Location = new System.Drawing.Point(320, 96);
            this.txtFuelPrice.Name = "txtFuelPrice";
            this.txtFuelPrice.Size = new System.Drawing.Size(100, 20);
            this.txtFuelPrice.TabIndex = 10;
            // 
            // txtFuelAmmount
            // 
            this.txtFuelAmmount.Location = new System.Drawing.Point(320, 70);
            this.txtFuelAmmount.Name = "txtFuelAmmount";
            this.txtFuelAmmount.Size = new System.Drawing.Size(100, 20);
            this.txtFuelAmmount.TabIndex = 9;
            // 
            // txtPreviousOdometer
            // 
            this.txtPreviousOdometer.Location = new System.Drawing.Point(320, 44);
            this.txtPreviousOdometer.Name = "txtPreviousOdometer";
            this.txtPreviousOdometer.Size = new System.Drawing.Size(100, 20);
            this.txtPreviousOdometer.TabIndex = 8;
            // 
            // txtCurrentOdometer
            // 
            this.txtCurrentOdometer.Location = new System.Drawing.Point(320, 16);
            this.txtCurrentOdometer.Name = "txtCurrentOdometer";
            this.txtCurrentOdometer.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentOdometer.TabIndex = 7;
            // 
            // lblFuelPrice
            // 
            this.lblFuelPrice.AutoSize = true;
            this.lblFuelPrice.Location = new System.Drawing.Point(3, 103);
            this.lblFuelPrice.Name = "lblFuelPrice";
            this.lblFuelPrice.Size = new System.Drawing.Size(68, 13);
            this.lblFuelPrice.TabIndex = 6;
            this.lblFuelPrice.Text = "Price per liter";
            // 
            // lblAmmountOfFuel
            // 
            this.lblAmmountOfFuel.AutoSize = true;
            this.lblAmmountOfFuel.Location = new System.Drawing.Point(3, 77);
            this.lblAmmountOfFuel.Name = "lblAmmountOfFuel";
            this.lblAmmountOfFuel.Size = new System.Drawing.Size(185, 13);
            this.lblAmmountOfFuel.TabIndex = 5;
            this.lblAmmountOfFuel.Text = "Current ammount of fuel tanked (liters)";
            // 
            // lvlPreviousOdometer
            // 
            this.lvlPreviousOdometer.AutoSize = true;
            this.lvlPreviousOdometer.Location = new System.Drawing.Point(3, 51);
            this.lvlPreviousOdometer.Name = "lvlPreviousOdometer";
            this.lvlPreviousOdometer.Size = new System.Drawing.Size(156, 13);
            this.lvlPreviousOdometer.TabIndex = 4;
            this.lvlPreviousOdometer.Text = "Previous odometer reading (km)";
            // 
            // lblCurrentOdometer
            // 
            this.lblCurrentOdometer.AutoSize = true;
            this.lblCurrentOdometer.Location = new System.Drawing.Point(3, 23);
            this.lblCurrentOdometer.Name = "lblCurrentOdometer";
            this.lblCurrentOdometer.Size = new System.Drawing.Size(149, 13);
            this.lblCurrentOdometer.TabIndex = 3;
            this.lblCurrentOdometer.Text = "Current odometer reading (km)";
            // 
            // btnCalculateFuel
            // 
            this.btnCalculateFuel.Location = new System.Drawing.Point(148, 135);
            this.btnCalculateFuel.Name = "btnCalculateFuel";
            this.btnCalculateFuel.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateFuel.TabIndex = 2;
            this.btnCalculateFuel.Text = "Calculate";
            this.btnCalculateFuel.UseVisualStyleBackColor = true;
            this.btnCalculateFuel.Click += new System.EventHandler(this.btnCalculateFuel_Click);
            // 
            // grpFuelResults
            // 
            this.grpFuelResults.Controls.Add(this.lblCostPerKilometer);
            this.grpFuelResults.Controls.Add(this.lblFuelConsumptionLperSweMile);
            this.grpFuelResults.Controls.Add(this.lblFuelConsumptionLPerMile);
            this.grpFuelResults.Controls.Add(this.lblFuelConsumptionLPerKm);
            this.grpFuelResults.Controls.Add(this.lblFuelConsumptionKmPerL);
            this.grpFuelResults.Controls.Add(this.lblResultCostPerKm);
            this.grpFuelResults.Controls.Add(this.lblResultFuelConsumptionLperSweMile);
            this.grpFuelResults.Controls.Add(this.lblResultFuelConsumptionLPerMile);
            this.grpFuelResults.Controls.Add(this.lblResultFuelConsumptionLPerKm);
            this.grpFuelResults.Controls.Add(this.lblResulFuelConsumptionKmPerL);
            this.grpFuelResults.Location = new System.Drawing.Point(0, 164);
            this.grpFuelResults.Name = "grpFuelResults";
            this.grpFuelResults.Size = new System.Drawing.Size(426, 145);
            this.grpFuelResults.TabIndex = 1;
            this.grpFuelResults.TabStop = false;
            this.grpFuelResults.Text = "Results";
            // 
            // lblCostPerKilometer
            // 
            this.lblCostPerKilometer.AutoSize = true;
            this.lblCostPerKilometer.Location = new System.Drawing.Point(6, 120);
            this.lblCostPerKilometer.Name = "lblCostPerKilometer";
            this.lblCostPerKilometer.Size = new System.Drawing.Size(100, 13);
            this.lblCostPerKilometer.TabIndex = 15;
            this.lblCostPerKilometer.Text = "Coster per kilometer";
            // 
            // lblFuelConsumptionLperSweMile
            // 
            this.lblFuelConsumptionLperSweMile.AutoSize = true;
            this.lblFuelConsumptionLperSweMile.Location = new System.Drawing.Point(6, 94);
            this.lblFuelConsumptionLperSweMile.Name = "lblFuelConsumptionLperSweMile";
            this.lblFuelConsumptionLperSweMile.Size = new System.Drawing.Size(166, 13);
            this.lblFuelConsumptionLperSweMile.TabIndex = 14;
            this.lblFuelConsumptionLperSweMile.Text = "Fuel consumption (lLitre/swe mile)";
            // 
            // lblFuelConsumptionLPerMile
            // 
            this.lblFuelConsumptionLPerMile.AutoSize = true;
            this.lblFuelConsumptionLPerMile.Location = new System.Drawing.Point(6, 69);
            this.lblFuelConsumptionLPerMile.Name = "lblFuelConsumptionLPerMile";
            this.lblFuelConsumptionLPerMile.Size = new System.Drawing.Size(176, 13);
            this.lblFuelConsumptionLPerMile.TabIndex = 13;
            this.lblFuelConsumptionLPerMile.Text = "Fuel Consumption (Litre/Metric Mile)";
            // 
            // lblFuelConsumptionLPerKm
            // 
            this.lblFuelConsumptionLPerKm.AutoSize = true;
            this.lblFuelConsumptionLPerKm.Location = new System.Drawing.Point(6, 43);
            this.lblFuelConsumptionLPerKm.Name = "lblFuelConsumptionLPerKm";
            this.lblFuelConsumptionLPerKm.Size = new System.Drawing.Size(139, 13);
            this.lblFuelConsumptionLPerKm.TabIndex = 12;
            this.lblFuelConsumptionLPerKm.Text = "Fuel consumption (Litre/Km)";
            // 
            // lblFuelConsumptionKmPerL
            // 
            this.lblFuelConsumptionKmPerL.AutoSize = true;
            this.lblFuelConsumptionKmPerL.Location = new System.Drawing.Point(6, 20);
            this.lblFuelConsumptionKmPerL.Name = "lblFuelConsumptionKmPerL";
            this.lblFuelConsumptionKmPerL.Size = new System.Drawing.Size(139, 13);
            this.lblFuelConsumptionKmPerL.TabIndex = 11;
            this.lblFuelConsumptionKmPerL.Text = "Fuel consumption (Km/Litre)";
            // 
            // lblResultCostPerKm
            // 
            this.lblResultCostPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultCostPerKm.Location = new System.Drawing.Point(314, 114);
            this.lblResultCostPerKm.Name = "lblResultCostPerKm";
            this.lblResultCostPerKm.Size = new System.Drawing.Size(94, 17);
            this.lblResultCostPerKm.TabIndex = 4;
            // 
            // lblResultFuelConsumptionLperSweMile
            // 
            this.lblResultFuelConsumptionLperSweMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultFuelConsumptionLperSweMile.Location = new System.Drawing.Point(314, 90);
            this.lblResultFuelConsumptionLperSweMile.Name = "lblResultFuelConsumptionLperSweMile";
            this.lblResultFuelConsumptionLperSweMile.Size = new System.Drawing.Size(94, 17);
            this.lblResultFuelConsumptionLperSweMile.TabIndex = 3;
            // 
            // lblResultFuelConsumptionLPerMile
            // 
            this.lblResultFuelConsumptionLPerMile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultFuelConsumptionLPerMile.Location = new System.Drawing.Point(314, 65);
            this.lblResultFuelConsumptionLPerMile.Name = "lblResultFuelConsumptionLPerMile";
            this.lblResultFuelConsumptionLPerMile.Size = new System.Drawing.Size(94, 17);
            this.lblResultFuelConsumptionLPerMile.TabIndex = 2;
            // 
            // lblResultFuelConsumptionLPerKm
            // 
            this.lblResultFuelConsumptionLPerKm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultFuelConsumptionLPerKm.Location = new System.Drawing.Point(314, 39);
            this.lblResultFuelConsumptionLPerKm.Name = "lblResultFuelConsumptionLPerKm";
            this.lblResultFuelConsumptionLPerKm.Size = new System.Drawing.Size(94, 17);
            this.lblResultFuelConsumptionLPerKm.TabIndex = 1;
            // 
            // lblResulFuelConsumptionKmPerL
            // 
            this.lblResulFuelConsumptionKmPerL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResulFuelConsumptionKmPerL.Location = new System.Drawing.Point(314, 16);
            this.lblResulFuelConsumptionKmPerL.Name = "lblResulFuelConsumptionKmPerL";
            this.lblResulFuelConsumptionKmPerL.Size = new System.Drawing.Size(94, 17);
            this.lblResulFuelConsumptionKmPerL.TabIndex = 0;
            // 
            // grpBMI
            // 
            this.grpBMI.Controls.Add(this.rbtnUscs);
            this.grpBMI.Controls.Add(this.rbtnMetric);
            this.grpBMI.Controls.Add(this.txtWeight);
            this.grpBMI.Controls.Add(this.txtHeight);
            this.grpBMI.Controls.Add(this.txtName);
            this.grpBMI.Controls.Add(this.lblWeight);
            this.grpBMI.Controls.Add(this.lblHeight);
            this.grpBMI.Controls.Add(this.lblName);
            this.grpBMI.Controls.Add(this.btnCalculateBMI);
            this.grpBMI.Controls.Add(this.grpBMIResult);
            this.grpBMI.Location = new System.Drawing.Point(454, 12);
            this.grpBMI.Name = "grpBMI";
            this.grpBMI.Size = new System.Drawing.Size(529, 309);
            this.grpBMI.TabIndex = 2;
            this.grpBMI.TabStop = false;
            this.grpBMI.Text = "BMI";
            // 
            // rbtnUscs
            // 
            this.rbtnUscs.AutoSize = true;
            this.rbtnUscs.Location = new System.Drawing.Point(313, 77);
            this.rbtnUscs.Name = "rbtnUscs";
            this.rbtnUscs.Size = new System.Drawing.Size(210, 17);
            this.rbtnUscs.TabIndex = 15;
            this.rbtnUscs.TabStop = true;
            this.rbtnUscs.Text = "United States customary units (lib, inch)";
            this.rbtnUscs.UseVisualStyleBackColor = true;
            this.rbtnUscs.CheckedChanged += new System.EventHandler(this.rbtnUscs_CheckedChanged);
            // 
            // rbtnMetric
            // 
            this.rbtnMetric.AutoSize = true;
            this.rbtnMetric.Location = new System.Drawing.Point(313, 51);
            this.rbtnMetric.Name = "rbtnMetric";
            this.rbtnMetric.Size = new System.Drawing.Size(117, 17);
            this.rbtnMetric.TabIndex = 14;
            this.rbtnMetric.TabStop = true;
            this.rbtnMetric.Text = "Metric Unit (kg, cm)";
            this.rbtnMetric.UseVisualStyleBackColor = true;
            this.rbtnMetric.CheckedChanged += new System.EventHandler(this.rbtnMetric_CheckedChanged);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(107, 74);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 13;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(107, 48);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(416, 20);
            this.txtName.TabIndex = 11;
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(7, 77);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(62, 13);
            this.lblWeight.TabIndex = 6;
            this.lblWeight.Text = "Weight (kg)";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(7, 51);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(61, 13);
            this.lblHeight.TabIndex = 5;
            this.lblHeight.Text = "Height (cm)";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Your name";
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.Location = new System.Drawing.Point(228, 135);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateBMI.TabIndex = 3;
            this.btnCalculateBMI.Text = "Calculate";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // grpBMIResult
            // 
            this.grpBMIResult.Controls.Add(this.lblWeightCatText);
            this.grpBMIResult.Controls.Add(this.label2);
            this.grpBMIResult.Controls.Add(this.lblBMIText);
            this.grpBMIResult.Controls.Add(this.lblResultWeightCategory);
            this.grpBMIResult.Controls.Add(this.lblResultBMI);
            this.grpBMIResult.Location = new System.Drawing.Point(0, 164);
            this.grpBMIResult.Name = "grpBMIResult";
            this.grpBMIResult.Size = new System.Drawing.Size(529, 145);
            this.grpBMIResult.TabIndex = 2;
            this.grpBMIResult.TabStop = false;
            this.grpBMIResult.Text = "Results";
            // 
            // lblWeightCatText
            // 
            this.lblWeightCatText.AutoSize = true;
            this.lblWeightCatText.Location = new System.Drawing.Point(10, 65);
            this.lblWeightCatText.Name = "lblWeightCatText";
            this.lblWeightCatText.Size = new System.Drawing.Size(86, 13);
            this.lblWeightCatText.TabIndex = 9;
            this.lblWeightCatText.Text = "Weight Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Your BMI";
            // 
            // lblBMIText
            // 
            this.lblBMIText.Location = new System.Drawing.Point(305, 101);
            this.lblBMIText.Name = "lblBMIText";
            this.lblBMIText.Size = new System.Drawing.Size(210, 30);
            this.lblBMIText.TabIndex = 7;
            // 
            // lblResultWeightCategory
            // 
            this.lblResultWeightCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultWeightCategory.Location = new System.Drawing.Point(421, 65);
            this.lblResultWeightCategory.Name = "lblResultWeightCategory";
            this.lblResultWeightCategory.Size = new System.Drawing.Size(94, 17);
            this.lblResultWeightCategory.TabIndex = 6;
            // 
            // lblResultBMI
            // 
            this.lblResultBMI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultBMI.Location = new System.Drawing.Point(421, 27);
            this.lblResultBMI.Name = "lblResultBMI";
            this.lblResultBMI.Size = new System.Drawing.Size(94, 17);
            this.lblResultBMI.TabIndex = 5;
            // 
            // grpBMR
            // 
            this.grpBMR.Controls.Add(this.btnClear);
            this.grpBMR.Controls.Add(this.lstBMRResult);
            this.grpBMR.Controls.Add(this.lblSelectedItem);
            this.grpBMR.Controls.Add(this.lblAge);
            this.grpBMR.Controls.Add(this.txtAge);
            this.grpBMR.Controls.Add(this.rbtnMale);
            this.grpBMR.Controls.Add(this.rbtnFemale);
            this.grpBMR.Controls.Add(this.btnUnselect);
            this.grpBMR.Controls.Add(this.btnCalculateBMR);
            this.grpBMR.Controls.Add(this.grpActiveLevel);
            this.grpBMR.Location = new System.Drawing.Point(12, 327);
            this.grpBMR.Name = "grpBMR";
            this.grpBMR.Size = new System.Drawing.Size(971, 332);
            this.grpBMR.TabIndex = 2;
            this.grpBMR.TabStop = false;
            this.grpBMR.Text = "BMR";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(750, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear all";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lstBMRResult
            // 
            this.lstBMRResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBMRResult.FormattingEnabled = true;
            this.lstBMRResult.ItemHeight = 14;
            this.lstBMRResult.Location = new System.Drawing.Point(371, 40);
            this.lstBMRResult.Name = "lstBMRResult";
            this.lstBMRResult.Size = new System.Drawing.Size(586, 242);
            this.lstBMRResult.TabIndex = 10;
            this.lstBMRResult.SelectedIndexChanged += new System.EventHandler(this.lstBMRResult_SelectedIndexChanged);
            // 
            // lblSelectedItem
            // 
            this.lblSelectedItem.AutoSize = true;
            this.lblSelectedItem.Location = new System.Drawing.Point(368, 303);
            this.lblSelectedItem.Name = "lblSelectedItem";
            this.lblSelectedItem.Size = new System.Drawing.Size(87, 13);
            this.lblSelectedItem.TabIndex = 9;
            this.lblSelectedItem.Text = "Selected Item: -1";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 71);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 7;
            this.lblAge.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(258, 64);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 3;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(71, 30);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 6;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(6, 30);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 5;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // btnUnselect
            // 
            this.btnUnselect.Location = new System.Drawing.Point(890, 303);
            this.btnUnselect.Name = "btnUnselect";
            this.btnUnselect.Size = new System.Drawing.Size(75, 23);
            this.btnUnselect.TabIndex = 4;
            this.btnUnselect.Text = "Unselect";
            this.btnUnselect.UseVisualStyleBackColor = true;
            this.btnUnselect.Click += new System.EventHandler(this.btnUnselect_Click);
            // 
            // btnCalculateBMR
            // 
            this.btnCalculateBMR.Location = new System.Drawing.Point(12, 287);
            this.btnCalculateBMR.Name = "btnCalculateBMR";
            this.btnCalculateBMR.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateBMR.TabIndex = 3;
            this.btnCalculateBMR.Text = "Calculate";
            this.btnCalculateBMR.UseVisualStyleBackColor = true;
            this.btnCalculateBMR.Click += new System.EventHandler(this.btnCalculateBMR_Click);
            // 
            // grpActiveLevel
            // 
            this.grpActiveLevel.Controls.Add(this.rbtnExtraActive);
            this.grpActiveLevel.Controls.Add(this.rbtnVeryActive);
            this.grpActiveLevel.Controls.Add(this.rbtnModeratlyActive);
            this.grpActiveLevel.Controls.Add(this.rbtnLightlyActive);
            this.grpActiveLevel.Controls.Add(this.rbtnSedentary);
            this.grpActiveLevel.Location = new System.Drawing.Point(12, 111);
            this.grpActiveLevel.Name = "grpActiveLevel";
            this.grpActiveLevel.Size = new System.Drawing.Size(346, 147);
            this.grpActiveLevel.TabIndex = 1;
            this.grpActiveLevel.TabStop = false;
            this.grpActiveLevel.Text = "Active level per week";
            // 
            // rbtnExtraActive
            // 
            this.rbtnExtraActive.AutoSize = true;
            this.rbtnExtraActive.Location = new System.Drawing.Point(6, 111);
            this.rbtnExtraActive.Name = "rbtnExtraActive";
            this.rbtnExtraActive.Size = new System.Drawing.Size(185, 17);
            this.rbtnExtraActive.TabIndex = 4;
            this.rbtnExtraActive.TabStop = true;
            this.rbtnExtraActive.Text = "Extra Active, hard exercises or job";
            this.rbtnExtraActive.UseVisualStyleBackColor = true;
            // 
            // rbtnVeryActive
            // 
            this.rbtnVeryActive.AutoSize = true;
            this.rbtnVeryActive.Location = new System.Drawing.Point(6, 88);
            this.rbtnVeryActive.Name = "rbtnVeryActive";
            this.rbtnVeryActive.Size = new System.Drawing.Size(141, 17);
            this.rbtnVeryActive.TabIndex = 3;
            this.rbtnVeryActive.TabStop = true;
            this.rbtnVeryActive.Text = "Very active (6 to 7 times)";
            this.rbtnVeryActive.UseVisualStyleBackColor = true;
            // 
            // rbtnModeratlyActive
            // 
            this.rbtnModeratlyActive.AutoSize = true;
            this.rbtnModeratlyActive.Location = new System.Drawing.Point(6, 65);
            this.rbtnModeratlyActive.Name = "rbtnModeratlyActive";
            this.rbtnModeratlyActive.Size = new System.Drawing.Size(172, 17);
            this.rbtnModeratlyActive.TabIndex = 2;
            this.rbtnModeratlyActive.TabStop = true;
            this.rbtnModeratlyActive.Text = "Moderatley active (3 to 5 times)";
            this.rbtnModeratlyActive.UseVisualStyleBackColor = true;
            // 
            // rbtnLightlyActive
            // 
            this.rbtnLightlyActive.AutoSize = true;
            this.rbtnLightlyActive.Location = new System.Drawing.Point(6, 42);
            this.rbtnLightlyActive.Name = "rbtnLightlyActive";
            this.rbtnLightlyActive.Size = new System.Drawing.Size(153, 17);
            this.rbtnLightlyActive.TabIndex = 1;
            this.rbtnLightlyActive.TabStop = true;
            this.rbtnLightlyActive.Text = "Lightly active ( 1 to 3 times)";
            this.rbtnLightlyActive.UseVisualStyleBackColor = true;
            // 
            // rbtnSedentary
            // 
            this.rbtnSedentary.AutoSize = true;
            this.rbtnSedentary.Location = new System.Drawing.Point(6, 19);
            this.rbtnSedentary.Name = "rbtnSedentary";
            this.rbtnSedentary.Size = new System.Drawing.Size(169, 17);
            this.rbtnSedentary.TabIndex = 0;
            this.rbtnSedentary.TabStop = true;
            this.rbtnSedentary.Text = "Sedantary (little or no exercise)";
            this.rbtnSedentary.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 673);
            this.Controls.Add(this.grpBMR);
            this.Controls.Add(this.grpBMI);
            this.Controls.Add(this.grpFuel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(1011, 712);
            this.Name = "MainForm";
            this.Text = "Universal Calculator";
            this.grpFuel.ResumeLayout(false);
            this.grpFuel.PerformLayout();
            this.grpFuelResults.ResumeLayout(false);
            this.grpFuelResults.PerformLayout();
            this.grpBMI.ResumeLayout(false);
            this.grpBMI.PerformLayout();
            this.grpBMIResult.ResumeLayout(false);
            this.grpBMIResult.PerformLayout();
            this.grpBMR.ResumeLayout(false);
            this.grpBMR.PerformLayout();
            this.grpActiveLevel.ResumeLayout(false);
            this.grpActiveLevel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFuel;
        private System.Windows.Forms.Button btnCalculateFuel;
        private System.Windows.Forms.GroupBox grpFuelResults;
        private System.Windows.Forms.GroupBox grpBMI;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.GroupBox grpBMIResult;
        private System.Windows.Forms.GroupBox grpBMR;
        private System.Windows.Forms.Button btnUnselect;
        private System.Windows.Forms.Button btnCalculateBMR;
        private System.Windows.Forms.GroupBox grpActiveLevel;
        private System.Windows.Forms.Label lblAmmountOfFuel;
        private System.Windows.Forms.Label lvlPreviousOdometer;
        private System.Windows.Forms.Label lblCurrentOdometer;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.TextBox txtFuelPrice;
        private System.Windows.Forms.TextBox txtFuelAmmount;
        private System.Windows.Forms.TextBox txtPreviousOdometer;
        private System.Windows.Forms.TextBox txtCurrentOdometer;
        private System.Windows.Forms.Label lblFuelPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton rbtnUscs;
        private System.Windows.Forms.RadioButton rbtnMetric;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.RadioButton rbtnExtraActive;
        private System.Windows.Forms.RadioButton rbtnVeryActive;
        private System.Windows.Forms.RadioButton rbtnModeratlyActive;
        private System.Windows.Forms.RadioButton rbtnLightlyActive;
        private System.Windows.Forms.RadioButton rbtnSedentary;
        private System.Windows.Forms.ListBox lstBMRResult;
        private System.Windows.Forms.Label lblSelectedItem;
        private System.Windows.Forms.Label lblCostPerKilometer;
        private System.Windows.Forms.Label lblFuelConsumptionLperSweMile;
        private System.Windows.Forms.Label lblFuelConsumptionLPerMile;
        private System.Windows.Forms.Label lblFuelConsumptionLPerKm;
        private System.Windows.Forms.Label lblFuelConsumptionKmPerL;
        private System.Windows.Forms.Label lblResultCostPerKm;
        private System.Windows.Forms.Label lblResultFuelConsumptionLperSweMile;
        private System.Windows.Forms.Label lblResultFuelConsumptionLPerMile;
        private System.Windows.Forms.Label lblResultFuelConsumptionLPerKm;
        private System.Windows.Forms.Label lblResulFuelConsumptionKmPerL;
        private System.Windows.Forms.Label lblBMIText;
        private System.Windows.Forms.Label lblResultWeightCategory;
        private System.Windows.Forms.Label lblResultBMI;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblWeightCatText;
        private System.Windows.Forms.Label label2;
    }
}

