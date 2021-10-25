using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace CS315_Project_2
{
    public partial class Converter : Form
    {


        private ArrayList unitsLength = new ArrayList() {
            "Inch (in)",
            "Centimeter (cm)",
            "Foot (ft)",
            "Yard (yd)",
            "Mile (mi)",
            "Kilometer (km)" };
        private ArrayList unitsVolume = new ArrayList() {
            "Liter",
            "Gallon"};

        Dictionary<string, string> Items = new Dictionary<string, string>();
        //conversions to meters
        Dictionary<string, double> Conversions = new Dictionary<string, double>();
        public Converter()
        {
            InitializeComponent();
            Items.Add("Inch (in)", "Inches");
            Items.Add("Centimeter (cm)", "Centimeters");
            Items.Add("Foot (ft)", "Feet");
            Items.Add("Yard (yd)", "Yards");
            Items.Add("Mile (mi)", "Miles");
            Items.Add("Kilometer (km)", "Kilometers");
            Items.Add("Liter", "Liters");
            Items.Add("Gallon", "Gallons");
            Conversions.Add("Inch (in)", 0.0254);
            Conversions.Add("Centimeter (cm)", 0.01);
            Conversions.Add("Foot (ft)", 0.3048);
            Conversions.Add("Yard (yd)", 0.9144);
            Conversions.Add("Mile (mi)", 1609.344);
            Conversions.Add("Kilometer (km)", 1000);
            Conversions.Add("Liter", 1);
            Conversions.Add("Gallon", 3.78541178);


            buttonConvert.Enabled = false;
            inputTextFrom.Focus();

        }
        private void setConversionToLabelText(string type)
        {
            labelInputTo.Text = Items[type];
        }
        private void setConversionFromLabelText(string type)
        {
            //required to change, for gallons, es
            labelInputFrom.Text = Items[type];
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTo.Items.Clear();
            comboBoxTo.SelectedItem = "";
            if (unitsLength.Contains(comboBoxFrom.SelectedItem))
            {
                foreach (string item in unitsLength)
                {
                    comboBoxTo.Items.Add(item);
                }
                comboBoxTo.Items.Remove(comboBoxFrom.SelectedItem);
                setConversionFromLabelText(comboBoxFrom.SelectedItem.ToString());
                comboBoxTo.SelectedIndex = 0;
                return;
            }
            foreach (string item in unitsVolume)
            {
                comboBoxTo.Items.Add(item);
            }
            comboBoxTo.Items.Remove(comboBoxFrom.SelectedItem);
            setConversionFromLabelText(comboBoxFrom.SelectedItem.ToString());
            comboBoxTo.SelectedIndex = 0;
            return;
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            setConversionToLabelText(comboBoxTo.SelectedItem.ToString());
        }

        private void inputTextFrom_TextChanged(object sender, EventArgs e)
        {
            if (inputTextFrom.Text != "")
            {
                buttonConvert.Enabled = true;
                return;
            }
            buttonConvert.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            inputTextFrom.Text = "";
            inputTextTo.Text = "";
            textBoxCalculation.Text = "";
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            if (comboBoxFrom.SelectedItem == null || comboBoxTo.SelectedItem == null)
                return;
            object temp = comboBoxFrom.SelectedItem;
            comboBoxFrom.SelectedItem = comboBoxTo.SelectedItem;
            comboBoxTo.SelectedItem = temp;
            if (buttonConvert.Enabled)
                buttonConvert_Click(sender, e);
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            double number;
            decimal display;
            try
            {
                number = Convert.ToDouble(inputTextFrom.Text);
                display = convertNumber(number, comboBoxFrom.SelectedItem.ToString(), comboBoxTo.SelectedItem.ToString());
                inputTextTo.Text = roundNumber(display).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            setCalculation();
        }
        private double conversionFactor(string from, string to)
        {
            return Conversions[from] / Conversions[to];
        }
        private decimal convertNumber(double number, string from, string to)
        {
            return Convert.ToDecimal(number * conversionFactor(from, to));
        }
        private decimal roundNumber(decimal number)
        {
            if (checkBoxDecimal.Checked)
                return decimal.Round(number, 2);
            return number;
        }
        private void setCalculation()
        {
            decimal factor = Convert.ToDecimal(conversionFactor(comboBoxFrom.SelectedItem.ToString(), comboBoxTo.SelectedItem.ToString()));
            string calculation = $"{inputTextFrom.Text} {Items[comboBoxFrom.SelectedItem.ToString()]} is " +
                $"{inputTextTo.Text} {Items[comboBoxTo.SelectedItem.ToString()]}\n\n";
            string calculation2 = $"{inputTextFrom.Text} * " +
                $"{decimal.Round(factor, 3)}" +
                $" = {inputTextTo.Text}";
            textBoxCalculation.Text = calculation + calculation2;
        }

        private void checkBoxDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonConvert.Enabled)
                buttonConvert_Click(sender, e);
        }

        private void inputTextFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && buttonConvert.Enabled)
            {
                buttonConvert_Click(sender, e);
            }
        }
    }
}
