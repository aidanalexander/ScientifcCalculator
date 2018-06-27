using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientifcCalculator
{
    public partial class Main : Form
    {
        // global variables
        Double results = 0;
        String operation = "";
        bool enter_value = false;
        String memory = "";

        public Main()
        {
            InitializeComponent();
        }

        private void ButtonNum_Click(object sender, EventArgs e)
        {
            // clears CalcDisplay if CalcDisplay.Text = "0" or enter_value = true
            if ((CalcDisplay.Text == "0") || (enter_value))
            {
                CalcDisplay.Text = "";
            }
            enter_value = false;

            // creates button object equal to the button clicked
            Button button = (Button)sender;

            // if button clicked is "."
            if (button.Text == ".")
            {
                // if CalcDisplay doesn't already have a period in it
                if (CalcDisplay.Text.Contains(".") == false)
                {
                    // set CalcDisplay text to the current text + "."
                    CalcDisplay.Text = CalcDisplay.Text + button.Text;
                }
            }
            else
            {
                CalcDisplay.Text = CalcDisplay.Text + button.Text;
            }
        }

        private void ClearEveryButton_Click(object sender, EventArgs e)
        {
            // set CalcDisplay to 0
            CalcDisplay.Text = "0";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // set CalcDisplay to 0 and ShowOperation label to empty string
            CalcDisplay.Text = "0";
            ShowOperation.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // if CalcDisplay length more than 0
            if (CalcDisplay.Text.Length > 0)
            {
                // remove 1 character from the end of the string
                CalcDisplay.Text = CalcDisplay.Text.Remove(CalcDisplay.Text.Length - 1, 1);
            }

            // if CalcDisplay empty set back to 0
            if (CalcDisplay.Text == "")
            {
                CalcDisplay.Text = "0";
            }
        }

        private void ArithmeticOperators(object sender, EventArgs e)
        {
            // create a button object of the pressed button
            Button button = (Button)sender;
            // takes the text from the pressed button
            operation = button.Text;
            // takes the CalcDisplay string and converts to a double 
            results = Double.Parse(CalcDisplay.Text);
            // clears CalcDisplay
            CalcDisplay.Text = "";
            // sets the ShowOperation label text to a string of the results variable + the operation text
            ShowOperation.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            ShowOperation.Text = "";
            // based on the operation string does different maths calculations  
            switch(operation)
            {
                case "+":
                    CalcDisplay.Text = (results + Double.Parse(CalcDisplay.Text)).ToString();
                    break;
                case "-":
                    CalcDisplay.Text = (results - Double.Parse(CalcDisplay.Text)).ToString();
                    break;
                case "*":
                    CalcDisplay.Text = (results * Double.Parse(CalcDisplay.Text)).ToString();
                    break;
                case "/":
                    CalcDisplay.Text = (results / Double.Parse(CalcDisplay.Text)).ToString();
                    break;
                case "Mod":
                    CalcDisplay.Text = (results % Double.Parse(CalcDisplay.Text)).ToString();
                    break;
                case "Exp":
                    // 
                    double i = Double.Parse(CalcDisplay.Text);
                    double q;
                    q = (results);
                    CalcDisplay.Text = Math.Exp(i * Math.Log(q * 4)).ToString();
                    break;
            }
        }

        private void LogButton_Click(object sender, EventArgs e)
        {
            ShowOperation.Text = System.Convert.ToString("log" + "(" + Double.Parse(CalcDisplay.Text) + ")");
            double log = Math.Log10(Double.Parse(CalcDisplay.Text));
            CalcDisplay.Text = System.Convert.ToString(log);
        }

        private void CubeRootButton_Click(object sender, EventArgs e)
        {
            ShowOperation.Text = System.Convert.ToString("3√" + "(" + Double.Parse(CalcDisplay.Text) + ")");
            double cubeRoot = Math.Pow(Double.Parse(CalcDisplay.Text), 1.0/3.0);
            CalcDisplay.Text = System.Convert.ToString(cubeRoot);
        }

        private void SinhButton_Click(object sender, EventArgs e)
        {
            double Sinh = Math.Sinh(Double.Parse(CalcDisplay.Text));
            ShowOperation.Text = System.Convert.ToString("sinh" + "(" + (CalcDisplay.Text) + ")");
            CalcDisplay.Text = System.Convert.ToString(Sinh);
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            double Sin = Math.Sin(Double.Parse(CalcDisplay.Text));
            ShowOperation.Text = System.Convert.ToString("sin" + "(" + (CalcDisplay.Text) + ")");
            CalcDisplay.Text = System.Convert.ToString(Sin);
        }

        private void CoshButton_Click(object sender, EventArgs e)
        {
            double Cosh = Math.Cosh(Double.Parse(CalcDisplay.Text));
            ShowOperation.Text = System.Convert.ToString("cosh" + "(" + (CalcDisplay.Text) + ")");
            CalcDisplay.Text = System.Convert.ToString(Cosh);
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            double Cos = Math.Cos(Double.Parse(CalcDisplay.Text));
            ShowOperation.Text = System.Convert.ToString("cos" + "(" + (CalcDisplay.Text) + ")");
            CalcDisplay.Text = System.Convert.ToString(Cos);
        }

        private void TanhButton_Click(object sender, EventArgs e)
        {
            double Tanh = Math.Tanh(Double.Parse(CalcDisplay.Text));
            ShowOperation.Text = System.Convert.ToString("tanh" + "(" + (CalcDisplay.Text) + ")");
            CalcDisplay.Text = System.Convert.ToString(Tanh);
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            double Tan = Math.Tan(Double.Parse(CalcDisplay.Text));
            ShowOperation.Text = System.Convert.ToString("tan" + "(" + (CalcDisplay.Text) + ")");
            CalcDisplay.Text = System.Convert.ToString(Tan);
        }

        private void PowerThreeButton_Click(object sender, EventArgs e)
        {
            ShowOperation.Text = System.Convert.ToString(Double.Parse(CalcDisplay.Text) + "^3");
            double cube = Math.Pow(Double.Parse(CalcDisplay.Text), 3.0);
            CalcDisplay.Text = System.Convert.ToString(cube);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            ShowOperation.Text = System.Convert.ToString(Double.Parse(CalcDisplay.Text) + "^2");
            double square = Math.Pow(Double.Parse(CalcDisplay.Text), 2.0);
            CalcDisplay.Text = System.Convert.ToString(square);
        }

        private void SwitchSignButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = System.Convert.ToString(Double.Parse(CalcDisplay.Text) * -1);
        }

        private void MCButton_Click(object sender, EventArgs e)
        {
            memory = "";
        }

        private void MRButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = memory;
        }

        private void MSButton_Click(object sender, EventArgs e)
        {
            memory = CalcDisplay.Text;
        }

        private void MPlusButton_Click(object sender, EventArgs e)
        {
            memory = System.Convert.ToString(Double.Parse(memory) + Double.Parse(CalcDisplay.Text));
        }

        private void MMinusButton_Click(object sender, EventArgs e)
        {
            memory = System.Convert.ToString(Double.Parse(memory) - Double.Parse(CalcDisplay.Text));
        }

        private void TenPowerButton_Click(object sender, EventArgs e)
        {
            ShowOperation.Text = System.Convert.ToString("10^" + Double.Parse(CalcDisplay.Text));
            double tenPowerOf = Math.Pow(10.0, Double.Parse(CalcDisplay.Text));
            CalcDisplay.Text = System.Convert.ToString(tenPowerOf);
        }
    }
}
