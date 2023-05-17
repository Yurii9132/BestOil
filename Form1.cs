using System.Diagnostics.SymbolStore;
using System.Text.RegularExpressions;

namespace BestOil
{
    public partial class Form1 : Form
    {
        List<Fuel> fuels = new List<Fuel>();
        List<Product> products = new List<Product>();
        List<RecordsProduct> records = new List<RecordsProduct>();
        public Form1()
        {
            InitializeComponent();
            fuels.Add(new Fuel("Petrol", 1.472M));
            fuels.Add(new Fuel("Diesel", 1.655M));

            products.Add(new Product("Hot-Dog", 5M));
            products.Add(new Product("Burger", 4.5M));
            products.Add(new Product("Chips", 3.5M));
            products.Add(new Product("Coca-Cola", 2.1M));

            comboBoxFuel.Items.AddRange(fuels.Select(o => o.Name).ToArray());
            comboBoxFuel.SelectedIndex = 0;

            for (int i = 0; i < products.Count; i++)
            {
                CheckBox ch = new CheckBox();
                ch.Location = new Point(6, 10 + i * 33);
                ch.Size = new Size(100, 28);
                ch.Text = products[i].Name;
                ch.CheckedChanged += Ch_CheckedChanged;
                
                TextBox tb = new TextBox();
                tb.Location = new Point(102, 10 + i * 33);
                tb.Text = products[i].price.ToString();
                tb.ReadOnly = true;
                tb.Size = new Size(59, 28);
                tb.TextAlign = HorizontalAlignment.Right;

                NumericUpDown num = new NumericUpDown();
                num.Location = new Point(167, 10 + i * 33);
                num.Size = new Size(68, 28);
                num.Enabled = false;
                num.Minimum = 0;
                num.Maximum = 1000;
                num.Value = 0;
                num.ValueChanged += Num_ValueChanged;

                panel1.Controls.Add(ch);
                panel1.Controls.Add(tb);
                panel1.Controls.Add(num);

                RecordsProduct rp = new RecordsProduct(ch, tb, num);
                records.Add(rp);
            }
        }

        private void Num_ValueChanged(object? sender, EventArgs e)
        {
            decimal sum = 0;
            foreach (var item in records)
            {
                sum += item.numUpDownNumber.Value * Convert.ToDecimal(item.TextBoxPrice.Text);
            }
            ToPayLableCafe.Text = Convert.ToString(sum);
        }

        private void Ch_CheckedChanged(object? sender, EventArgs e)
        {
            CheckBox check = sender as CheckBox;
            int index = records.FindIndex(r => r.checkBoxName == check);
            records[index].numUpDownNumber.Enabled = check.Checked;
            if(check.Checked == false)
            {
                records[index].numUpDownNumber.Value = 0;
            }
        }

        private void comboBoxFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = (sender as ComboBox).SelectedIndex;
            textBoxFuelPrice.Text = fuels[index].price.ToString();
        }


        private void Quantity_CheckedChanged(object sender, EventArgs e)
        {
            QuantityNumericUpDown.Enabled = Quantity.Checked;
            SumNumericUpDown.Value = 0;
        }

        private void Sum_CheckedChanged(object sender, EventArgs e)
        {
            SumNumericUpDown.Enabled = Sum.Checked;
            QuantityNumericUpDown.Value = 0;
        }

        void calcSumFuel()
        {
            decimal sumToPayFuel = 0;
            if (Quantity.Checked)
            {
                sumToPayFuel = QuantityNumericUpDown.Value *
                    Convert.ToDecimal(textBoxFuelPrice.Text);
                SumNumericUpDown.Value = sumToPayFuel;
            }
            if (Sum.Checked)
            {
                decimal volume = SumNumericUpDown.Value /
                    Convert.ToDecimal(textBoxFuelPrice.Text);
                QuantityNumericUpDown.Text = volume.ToString();
            }
            ToPayLablePetrol.Text = Math.Round(sumToPayFuel, 2).ToString();
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calcSumFuel();
        }

        private void SumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            calcSumFuel();
        }
    }

    internal class Fuel
    {
        public string Name { get; set; }
        public decimal price { get; set; }
        public Fuel(string name, decimal price)
        {
            Name = name;
            this.price = price;
        }
    }

    internal class Product
    {
        public string Name { get; set; }
        public decimal price { get; set; }
        public Product(string name, decimal price)
        {
            Name = name;
            this.price = price;
        }
    }

    class RecordsProduct
    {
        public CheckBox checkBoxName { get; set; }
        public TextBox TextBoxPrice { get; set; }
        public NumericUpDown numUpDownNumber { get; set; }
        public RecordsProduct(CheckBox checkBoxName, TextBox TextBoxPrice, NumericUpDown numUpDownNumber)
        {
            this.checkBoxName = checkBoxName;
            this.TextBoxPrice = TextBoxPrice;
            this.numUpDownNumber = numUpDownNumber;
        }
    }
}