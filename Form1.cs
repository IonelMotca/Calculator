using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Stintific
{
    public partial class Form1 : Form
    {
        double result;
        string arithematicOperator;
        double firstNum;
        bool isOperatorClick = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 460;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (scinetificTextBox.Text == "0" || isOperatorClick) 
                scinetificTextBox.Clear();
            isOperatorClick = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!scinetificTextBox.Text.Contains("."))
                    scinetificTextBox.Text += button.Text;
            }
            else
            {
                scinetificTextBox.Text += button.Text;
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            int index = scinetificTextBox.Text.Length;
            index--;
            scinetificTextBox.Text = scinetificTextBox.Text.Remove(index);
            if(scinetificTextBox.Text == string.Empty)
            {
                scinetificTextBox.Text = "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            scinetificTextBox.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            result = double.Parse(scinetificTextBox.Text);
            result = result * -1;
            scinetificTextBox.Text = result.ToString();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNum = double.Parse(scinetificTextBox.Text);
            Button btn = (Button)sender;
            arithematicOperator = btn.Text;
            isOperatorClick = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            switch(arithematicOperator)
            {
                case "+":
                    scinetificTextBox.Text = (firstNum + double.Parse(scinetificTextBox.Text)).ToString();
                    break;
                case "-":
                    scinetificTextBox.Text = (firstNum - double.Parse(scinetificTextBox.Text)).ToString();
                    break;
                 
                case "*":
                    scinetificTextBox.Text = (firstNum * double.Parse(scinetificTextBox.Text)).ToString();
                    
                    break;
                case "/":
                    scinetificTextBox.Text = (firstNum / double.Parse(scinetificTextBox.Text)).ToString();
                    
                    break;
                case "MOD":
                    scinetificTextBox.Text = (firstNum % double.Parse(scinetificTextBox.Text)).ToString();
                
                    break;

                default:
                    break;                 
            }

        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            titleLabel.Text = string.Empty;
            this.Width = 460;

        }

        private void convertorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 814;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double val = double.Parse(scinetificTextBox.Text);
            titleLabel.Text = "LOG(" + val + ")";
            val = Math.Log10(val);
            scinetificTextBox.Text = val.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double val = double.Parse(scinetificTextBox.Text);
            titleLabel.Text = "RAD(" + val + ")";
            val = Math.Sqrt(val);
            scinetificTextBox.Text = val.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double val = double.Parse(scinetificTextBox.Text);
            titleLabel.Text = val + "^2";
            val = Math.Pow(val,2);
            scinetificTextBox.Text = val.ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double val = double.Parse(scinetificTextBox.Text);
            titleLabel.Text = "Sin("+val+")";
            val = Math.Sin(val);
            scinetificTextBox.Text = val.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(scinetificTextBox.Text);
                titleLabel.Text = "DEC(" + scinetificTextBox.Text + ")";
                scinetificTextBox.Text = System.Convert.ToString(a, 10);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

            double val = double.Parse(scinetificTextBox.Text);
            titleLabel.Text = val + "^3";
            val = Math.Pow(val, 3);
            scinetificTextBox.Text = val.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            double val = double.Parse(scinetificTextBox.Text);
            titleLabel.Text = "Cos(" + val + ")";
            val = Math.Cos(val);
            scinetificTextBox.Text = val.ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(scinetificTextBox.Text);
                titleLabel.Text = "HEX(" + scinetificTextBox.Text + ")";
                scinetificTextBox.Text = System.Convert.ToString(a, 16);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double val = double.Parse(scinetificTextBox.Text);
            val = 1 / val;
            scinetificTextBox.Text = val.ToString();
        }

        private void button38_Click(object sender, EventArgs e)
        {

            double val = double.Parse(scinetificTextBox.Text);
            titleLabel.Text = "Tan(" + val + ")";
            val = Math.Tan(val);
            scinetificTextBox.Text = val.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {

            try
            {
                int a = int.Parse(scinetificTextBox.Text);
                titleLabel.Text = "BIN(" + scinetificTextBox.Text + ")";
                scinetificTextBox.Text = System.Convert.ToString(a, 2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double val = double.Parse(scinetificTextBox.Text);
            titleLabel.Text = "Ln(" + val + ")";
            val = Math.Log(val);
            scinetificTextBox.Text = val.ToString();
        }

        private void button29_Click(object sender, EventArgs e)
        {

            try
            {
                int a = int.Parse(scinetificTextBox.Text);
                titleLabel.Text = "OCT(" + scinetificTextBox.Text + ")";
                scinetificTextBox.Text = System.Convert.ToString(a, 8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {

            double val = double.Parse(scinetificTextBox.Text);
            titleLabel.Text = "%(" + val + ")";
            val = val / 100;
            scinetificTextBox.Text = val.ToString();
        }

        private void temperatureConvertbutton_Click(object sender, EventArgs e)
        {
            conversionTextBox.Clear();
            float number = 0f;
            if (temperatureTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter a temperture you wish to convert", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                number = Convert.ToSingle(temperatureTextBox.Text);

            }
            catch
            {
                MessageBox.Show("Invalid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (CeltoFahRadioButton.Checked)
            {
                conversionTextBox.Text = ((number * 9 / 5) + 32).ToString();

            }

            if (FahtoCelRadioButton.Checked)
            {
                conversionTextBox.Text = ((number - 32) * 5 / 9).ToString();
            }
            if (KeltoCelRadioButton.Checked)
            {
                conversionTextBox.Text = (number - 273.15).ToString();
            }
            if (KeltoFahRadioButton.Checked)
            {
                conversionTextBox.Text = ((number - 273.15) * 9 / 5 + 32).ToString();
            }
        }

        private void temperatureresetbutton_Click(object sender, EventArgs e)
        {
            conversionTextBox.Clear();
            temperatureTextBox.Clear();
            temperatureTextBox.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
