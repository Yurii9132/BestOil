namespace BestOil
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GasStation = new GroupBox();
            SumNumericUpDown = new NumericUpDown();
            QuantityNumericUpDown = new NumericUpDown();
            Quantity = new RadioButton();
            Sum = new RadioButton();
            ToPayFuel = new GroupBox();
            ToPayLablePetrol = new Label();
            gbp1 = new Label();
            lableLiter = new Label();
            label1 = new Label();
            gbpFuelPrice = new Label();
            textBoxFuelPrice = new TextBox();
            comboBoxFuel = new ComboBox();
            price = new Label();
            fuel = new Label();
            MiniCafe = new GroupBox();
            panel1 = new Panel();
            ToPayCafe = new GroupBox();
            ToPayLableCafe = new Label();
            gbp2 = new Label();
            TotalPayable = new GroupBox();
            ToPayLableTotal = new Label();
            gbpTotal = new Label();
            Count = new Button();
            GasStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SumNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).BeginInit();
            ToPayFuel.SuspendLayout();
            MiniCafe.SuspendLayout();
            ToPayCafe.SuspendLayout();
            TotalPayable.SuspendLayout();
            SuspendLayout();
            // 
            // GasStation
            // 
            GasStation.Controls.Add(SumNumericUpDown);
            GasStation.Controls.Add(QuantityNumericUpDown);
            GasStation.Controls.Add(Quantity);
            GasStation.Controls.Add(Sum);
            GasStation.Controls.Add(ToPayFuel);
            GasStation.Controls.Add(lableLiter);
            GasStation.Controls.Add(label1);
            GasStation.Controls.Add(gbpFuelPrice);
            GasStation.Controls.Add(textBoxFuelPrice);
            GasStation.Controls.Add(comboBoxFuel);
            GasStation.Controls.Add(price);
            GasStation.Controls.Add(fuel);
            GasStation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            GasStation.Location = new Point(12, 36);
            GasStation.Name = "GasStation";
            GasStation.Size = new Size(252, 310);
            GasStation.TabIndex = 0;
            GasStation.TabStop = false;
            GasStation.Text = "Gas station";
            // 
            // SumNumericUpDown
            // 
            SumNumericUpDown.DecimalPlaces = 2;
            SumNumericUpDown.Enabled = false;
            SumNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            SumNumericUpDown.Location = new Point(130, 178);
            SumNumericUpDown.Name = "SumNumericUpDown";
            SumNumericUpDown.Size = new Size(84, 29);
            SumNumericUpDown.TabIndex = 7;
            SumNumericUpDown.ValueChanged += SumNumericUpDown_ValueChanged;
            // 
            // QuantityNumericUpDown
            // 
            QuantityNumericUpDown.DecimalPlaces = 2;
            QuantityNumericUpDown.Enabled = false;
            QuantityNumericUpDown.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            QuantityNumericUpDown.Location = new Point(130, 144);
            QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            QuantityNumericUpDown.Size = new Size(84, 29);
            QuantityNumericUpDown.TabIndex = 7;
            QuantityNumericUpDown.ValueChanged += QuantityNumericUpDown_ValueChanged;
            // 
            // Quantity
            // 
            Quantity.AutoSize = true;
            Quantity.Location = new Point(26, 146);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(88, 25);
            Quantity.TabIndex = 6;
            Quantity.TabStop = true;
            Quantity.Text = "Quantity";
            Quantity.UseVisualStyleBackColor = true;
            Quantity.CheckedChanged += Quantity_CheckedChanged;
            // 
            // Sum
            // 
            Sum.AutoSize = true;
            Sum.Location = new Point(26, 182);
            Sum.Name = "Sum";
            Sum.Size = new Size(60, 25);
            Sum.TabIndex = 6;
            Sum.TabStop = true;
            Sum.Text = "Sum";
            Sum.UseVisualStyleBackColor = true;
            Sum.CheckedChanged += Sum_CheckedChanged;
            // 
            // ToPayFuel
            // 
            ToPayFuel.Controls.Add(ToPayLablePetrol);
            ToPayFuel.Controls.Add(gbp1);
            ToPayFuel.Location = new Point(10, 219);
            ToPayFuel.Name = "ToPayFuel";
            ToPayFuel.Size = new Size(220, 85);
            ToPayFuel.TabIndex = 4;
            ToPayFuel.TabStop = false;
            ToPayFuel.Text = "To pay";
            // 
            // ToPayLablePetrol
            // 
            ToPayLablePetrol.AutoSize = true;
            ToPayLablePetrol.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            ToPayLablePetrol.Location = new Point(99, 32);
            ToPayLablePetrol.Name = "ToPayLablePetrol";
            ToPayLablePetrol.Size = new Size(71, 40);
            ToPayLablePetrol.TabIndex = 1;
            ToPayLablePetrol.Text = "0.00";
            // 
            // gbp1
            // 
            gbp1.AutoSize = true;
            gbp1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            gbp1.Location = new Point(178, 57);
            gbp1.Name = "gbp1";
            gbp1.Size = new Size(36, 20);
            gbp1.TabIndex = 0;
            gbp1.Text = "GBP";
            // 
            // lableLiter
            // 
            lableLiter.AutoSize = true;
            lableLiter.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lableLiter.Location = new Point(211, 153);
            lableLiter.Name = "lableLiter";
            lableLiter.Size = new Size(38, 20);
            lableLiter.TabIndex = 0;
            lableLiter.Text = "Liter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(215, 192);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "GBP";
            // 
            // gbpFuelPrice
            // 
            gbpFuelPrice.AutoSize = true;
            gbpFuelPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbpFuelPrice.Location = new Point(215, 99);
            gbpFuelPrice.Name = "gbpFuelPrice";
            gbpFuelPrice.Size = new Size(29, 15);
            gbpFuelPrice.TabIndex = 0;
            gbpFuelPrice.Text = "GBP";
            // 
            // textBoxFuelPrice
            // 
            textBoxFuelPrice.Location = new Point(93, 85);
            textBoxFuelPrice.Name = "textBoxFuelPrice";
            textBoxFuelPrice.ReadOnly = true;
            textBoxFuelPrice.Size = new Size(119, 29);
            textBoxFuelPrice.TabIndex = 3;
            // 
            // comboBoxFuel
            // 
            comboBoxFuel.FormattingEnabled = true;
            comboBoxFuel.Location = new Point(93, 39);
            comboBoxFuel.Name = "comboBoxFuel";
            comboBoxFuel.Size = new Size(121, 29);
            comboBoxFuel.TabIndex = 2;
            comboBoxFuel.SelectedIndexChanged += comboBoxFuel_SelectedIndexChanged;
            // 
            // price
            // 
            price.AutoSize = true;
            price.Location = new Point(22, 91);
            price.Name = "price";
            price.Size = new Size(44, 21);
            price.TabIndex = 1;
            price.Text = "Price";
            // 
            // fuel
            // 
            fuel.AutoSize = true;
            fuel.Location = new Point(22, 42);
            fuel.Name = "fuel";
            fuel.Size = new Size(39, 21);
            fuel.TabIndex = 0;
            fuel.Text = "Fuel";
            // 
            // MiniCafe
            // 
            MiniCafe.Controls.Add(panel1);
            MiniCafe.Controls.Add(ToPayCafe);
            MiniCafe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MiniCafe.Location = new Point(305, 36);
            MiniCafe.Name = "MiniCafe";
            MiniCafe.Size = new Size(252, 310);
            MiniCafe.TabIndex = 1;
            MiniCafe.TabStop = false;
            MiniCafe.Text = "Mini-Cafe";
            // 
            // panel1
            // 
            panel1.Location = new Point(7, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(238, 179);
            panel1.TabIndex = 3;
            // 
            // ToPayCafe
            // 
            ToPayCafe.Controls.Add(ToPayLableCafe);
            ToPayCafe.Controls.Add(gbp2);
            ToPayCafe.Location = new Point(15, 219);
            ToPayCafe.Name = "ToPayCafe";
            ToPayCafe.Size = new Size(220, 85);
            ToPayCafe.TabIndex = 0;
            ToPayCafe.TabStop = false;
            ToPayCafe.Text = "To pay";
            // 
            // ToPayLableCafe
            // 
            ToPayLableCafe.AutoSize = true;
            ToPayLableCafe.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            ToPayLableCafe.Location = new Point(101, 32);
            ToPayLableCafe.Name = "ToPayLableCafe";
            ToPayLableCafe.Size = new Size(71, 40);
            ToPayLableCafe.TabIndex = 1;
            ToPayLableCafe.Text = "0.00";
            // 
            // gbp2
            // 
            gbp2.AutoSize = true;
            gbp2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            gbp2.Location = new Point(178, 57);
            gbp2.Name = "gbp2";
            gbp2.Size = new Size(36, 20);
            gbp2.TabIndex = 0;
            gbp2.Text = "GBP";
            // 
            // TotalPayable
            // 
            TotalPayable.Controls.Add(ToPayLableTotal);
            TotalPayable.Controls.Add(gbpTotal);
            TotalPayable.Controls.Add(Count);
            TotalPayable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPayable.Location = new Point(12, 373);
            TotalPayable.Name = "TotalPayable";
            TotalPayable.Size = new Size(545, 105);
            TotalPayable.TabIndex = 2;
            TotalPayable.TabStop = false;
            TotalPayable.Text = "Total payable";
            // 
            // ToPayLableTotal
            // 
            ToPayLableTotal.AutoSize = true;
            ToPayLableTotal.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            ToPayLableTotal.Location = new Point(411, 43);
            ToPayLableTotal.Name = "ToPayLableTotal";
            ToPayLableTotal.Size = new Size(85, 47);
            ToPayLableTotal.TabIndex = 1;
            ToPayLableTotal.Text = "0.00";
            // 
            // gbpTotal
            // 
            gbpTotal.AutoSize = true;
            gbpTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            gbpTotal.Location = new Point(503, 70);
            gbpTotal.Name = "gbpTotal";
            gbpTotal.Size = new Size(36, 20);
            gbpTotal.TabIndex = 0;
            gbpTotal.Text = "GBP";
            // 
            // Count
            // 
            Count.Location = new Point(121, 28);
            Count.Name = "Count";
            Count.Size = new Size(129, 62);
            Count.TabIndex = 0;
            Count.Text = "Count";
            Count.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 506);
            Controls.Add(MiniCafe);
            Controls.Add(TotalPayable);
            Controls.Add(GasStation);
            Name = "Form1";
            Text = "Form1";
            GasStation.ResumeLayout(false);
            GasStation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SumNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)QuantityNumericUpDown).EndInit();
            ToPayFuel.ResumeLayout(false);
            ToPayFuel.PerformLayout();
            MiniCafe.ResumeLayout(false);
            ToPayCafe.ResumeLayout(false);
            ToPayCafe.PerformLayout();
            TotalPayable.ResumeLayout(false);
            TotalPayable.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox GasStation;
        private GroupBox MiniCafe;
        private GroupBox TotalPayable;
        private ComboBox comboBoxFuel;
        private Label price;
        private Label fuel;
        private GroupBox ToPayFuel;
        private Label ToPayLablePetrol;
        private Label gbp1;
        private TextBox textBoxFuelPrice;
        private GroupBox ToPayCafe;
        private Label ToPayLableCafe;
        private Label gbp2;
        private Button Count;
        private Label label1;
        private Label gbpFuelPrice;
        private Label ToPayLableTotal;
        private Label gbpTotal;
        private RadioButton Quantity;
        private RadioButton Sum;
        private Label lableLiter;
        private NumericUpDown SumNumericUpDown;
        private NumericUpDown QuantityNumericUpDown;
        private Panel panel1;
    }
}