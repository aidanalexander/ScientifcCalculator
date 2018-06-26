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
        Double results = 0;
        String operation = "";
        bool enter_value = false;

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalcDisplay_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
        }

        private void PeriodButton_Click(object sender, EventArgs e)
        {
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {

        }

        private void MSButton_Click(object sender, EventArgs e)
        {

        }

        private void MMinusButton_Click(object sender, EventArgs e)
        {

        }

        private void FactorialButton_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNum_Click(object sender, EventArgs e)
        {
            // clears CalcDisplay if CalcDisplay.Text = "0" or enter_value == true
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
            // set CalcDisplay to 0
            CalcDisplay.Text = "0";
            ShowOperation.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // if CalcDisplay length more than 0
            if (CalcDisplay.Text.Length > 0)
            {
                CalcDisplay.Text = CalcDisplay.Text.Remove(CalcDisplay.Text.Length - 1, 1);
            }

            // if CalcDisplay empty set back to 0
            if (CalcDisplay.Text == "")
            {
                CalcDisplay.Text = "0";
            }
        }

        private void CalcDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ArithmeticOperators(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            results = Double.Parse(CalcDisplay.Text);
            CalcDisplay.Text = "";
            ShowOperation.Text = System.Convert.ToString(results) + " " + operation;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            ShowOperation.Text = "";
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
    }
}
