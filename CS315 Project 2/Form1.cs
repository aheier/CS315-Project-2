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
            //buttonSwap.Enabled = false;

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
            if (unitsLength.Contains(comboBoxFrom.SelectedItem)){
                foreach (string item in unitsLength)
                {
                    comboBoxTo.Items.Add(item);
                }
                comboBoxTo.Items.Remove(comboBoxFrom.SelectedItem);
                setConversionFromLabelText(comboBoxFrom.SelectedItem.ToString());
                comboBoxTo.SelectedIndex = 0;
                return;
            }
            foreach(string item in unitsVolume)
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
            if(inputTextFrom.Text != "")
            {
                buttonConvert.Enabled = true;
                return;
            }
            buttonConvert.Enabled = false;
        }
    }
}
