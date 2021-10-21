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

        private ArrayList unitsMeasurement = new ArrayList() {
            "Inch (in)",
            "Centimeter (cm)",
            "Foot (ft)",
            "Yard (yd)",
            "Mile (mi)",
            "Kilometer (km)" };
        private ArrayList unitsContainers = new ArrayList() {
            "Liter",
            "Gallon"};
    public Converter()
        {
            InitializeComponent();
            buttonConvert.Enabled = false;

        }
        
        private void setConversionToLabelText()
        {
            labelInputTo.Text = comboBoxTo.SelectedItem.ToString().Substring(0, comboBoxTo.SelectedItem.ToString().Length - 5) + 's';
        }
        private void setConversionFromLabelText()
        {
            //required to change, for gallons, es
            labelInputFrom.Text = comboBoxFrom.SelectedItem.ToString().Substring(0, comboBoxFrom.SelectedItem.ToString().Length - 5) + 's';
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTo.Items.Clear();
            comboBoxTo.SelectedItem = "";
            if (unitsMeasurement.Contains(comboBoxFrom.SelectedItem)){
                foreach (string item in unitsMeasurement)
                {
                    comboBoxTo.Items.Add(item);
                }
                comboBoxTo.Items.Remove(comboBoxFrom.SelectedItem);
                setConversionFromLabelText();
                return;
            }
            foreach(string item in unitsContainers)
            {
                comboBoxTo.Items.Add(item);
            }
            comboBoxTo.Items.Remove(comboBoxFrom.SelectedItem);
            setConversionFromLabelText();
            return;
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            setConversionToLabelText();
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

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                Double numberToConvert = Convert.ToDouble(inputTextFrom.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Exception: {ex}");
            }
        }
    }
}
