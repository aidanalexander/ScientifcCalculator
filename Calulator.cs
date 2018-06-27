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
                case "^":
                    CalcDisplay.Text = Math.Pow(results, Double.Parse(CalcDisplay.Text)).ToString();
                    break;
                case "√":
                    CalcDisplay.Text = Math.Pow(results, 1 /Double.Parse(CalcDisplay.Text)).ToString();
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
            // sets ShowOperation label to be "log(" followed by the number in the CalcDisplay then a ")"
            ShowOperation.Text = System.Convert.ToString("log(" + Double.Parse(CalcDisplay.Text) + ")");
            // calculates Log10 of the number in the CalcDisplay
            double log = Math.Log10(Double.Parse(CalcDisplay.Text));
            // sets the CalcDisplay to the result from the log variable above
            CalcDisplay.Text = System.Convert.ToString(log);
        }

        private void CubeRootButton_Click(object sender, EventArgs e)
        {
            // sets ShowOperation label to be "3√(" followed by the number in the CalcDisplay then a ")"
            ShowOperation.Text = System.Convert.ToString("3√(" + Double.Parse(CalcDisplay.Text) + ")");
            // calculates cube root of the number in the CalcDisplay
            double cubeRoot = Math.Pow(Double.Parse(CalcDisplay.Text), 1.0/3.0);
            // sets the CalcDisplay to the result from the cubeRoot variable above
            CalcDisplay.Text = System.Convert.ToString(cubeRoot);
        }

        private void SinhButton_Click(object sender, EventArgs e)
        {
            // calculates sinh of the number in the CalcDisplay
            double Sinh = Math.Sinh(Double.Parse(CalcDisplay.Text));
            // sets ShowOperation label to be "sinh(" followed by the number in the CalcDisplay then a ")"
            ShowOperation.Text = System.Convert.ToString("sinh(" + (CalcDisplay.Text) + ")");
            // sets the CalcDisplay to the result from the Sinh variable above
            CalcDisplay.Text = System.Convert.ToString(Sinh);
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            // calculates sin of the number in the CalcDisplay
            double Sin = Math.Sin(Double.Parse(CalcDisplay.Text));
            // sets ShowOperation label to be "sin(" followed by the number in the CalcDisplay then a ")"
            ShowOperation.Text = System.Convert.ToString("sin(" + (CalcDisplay.Text) + ")");
            // sets the CalcDisplay to the result from the Sin variable above
            CalcDisplay.Text = System.Convert.ToString(Sin);
        }

        private void CoshButton_Click(object sender, EventArgs e)
        {
            // calculates cosh of the number in the CalcDisplay
            double Cosh = Math.Cosh(Double.Parse(CalcDisplay.Text));
            // sets ShowOperation label to be "cosh(" followed by the number in the CalcDisplay then a ")"
            ShowOperation.Text = System.Convert.ToString("cosh(" + (CalcDisplay.Text) + ")");
            // sets the CalcDisplay to the result from the Cosh variable above
            CalcDisplay.Text = System.Convert.ToString(Cosh);
        }
        
        private void CosButton_Click(object sender, EventArgs e)
        {
            // calculates cos of the number in the CalcDisplay
            double Cos = Math.Cos(Double.Parse(CalcDisplay.Text));
            // sets ShowOperation label to be "cos(" followed by the number in the CalcDisplay then a ")"
            ShowOperation.Text = System.Convert.ToString("cos(" + (CalcDisplay.Text) + ")");
            // sets the CalcDisplay to the result from the Cos variable above
            CalcDisplay.Text = System.Convert.ToString(Cos);
        }

        private void TanhButton_Click(object sender, EventArgs e)
        {
            // calculates tanh of the number in the CalcDisplay
            double Tanh = Math.Tanh(Double.Parse(CalcDisplay.Text));
            // sets ShowOperation label to be "tanh(" followed by the number in the CalcDisplay then a ")"
            ShowOperation.Text = System.Convert.ToString("tanh(" + (CalcDisplay.Text) + ")");
            // sets the CalcDisplay to the result from the Tanh variable above
            CalcDisplay.Text = System.Convert.ToString(Tanh);
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            // calculates tan of the number in the CalcDisplay
            double Tan = Math.Tan(Double.Parse(CalcDisplay.Text));
            // sets ShowOperation label to be "tan(" followed by the number in the CalcDisplay then a ")"
            ShowOperation.Text = System.Convert.ToString("tan(" + (CalcDisplay.Text) + ")");
            // sets the CalcDisplay to the result from the Tan variable above
            CalcDisplay.Text = System.Convert.ToString(Tan);
        }

        private void PowerThreeButton_Click(object sender, EventArgs e)
        {
            // sets ShowOperation label to be the number in the CalcDisplay then a "^3"
            ShowOperation.Text = System.Convert.ToString(Double.Parse(CalcDisplay.Text) + "^3");
            // calculates cube of the number in the CalcDisplay
            double cube = Math.Pow(Double.Parse(CalcDisplay.Text), 3.0);
            // sets the CalcDisplay to the result from the cube variable above
            CalcDisplay.Text = System.Convert.ToString(cube);
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            // sets ShowOperation label to be the number in the CalcDisplay then a "^2"
            ShowOperation.Text = System.Convert.ToString(Double.Parse(CalcDisplay.Text) + "^2");
            // calculates square of the number in the CalcDisplay
            double square = Math.Pow(Double.Parse(CalcDisplay.Text), 2.0);
            // sets the CalcDisplay to the result from the square variable above
            CalcDisplay.Text = System.Convert.ToString(square);
        }

        private void SwitchSignButton_Click(object sender, EventArgs e)
        {
            // flips the CalcDisplay value between negative and positive
            CalcDisplay.Text = System.Convert.ToString(Double.Parse(CalcDisplay.Text) * -1);
        }

        private void MCButton_Click(object sender, EventArgs e)
        {
            // clears memory
            memory = "";
        }

        private void MRButton_Click(object sender, EventArgs e)
        {
            // if memory not empty string
            if (memory != "")
            {
                // sets CalcDisplay to the value stored in memory
                CalcDisplay.Text = memory;
            }
            else
            {
                // or sets the CalcDisplay to 0
                CalcDisplay.Text = 0;
            }
            
        }

        private void MSButton_Click(object sender, EventArgs e)
        {
            // sets the memory equal to the number currently in the CalcDisplay
            memory = CalcDisplay.Text;
        }

        private void MPlusButton_Click(object sender, EventArgs e)
        {
            // sets memory equal to memory + the current value in the CalcDisplay
            memory = System.Convert.ToString(Double.Parse(memory) + Double.Parse(CalcDisplay.Text));
        }

        private void MMinusButton_Click(object sender, EventArgs e)
        {
            // sets memory equal to memory - the current value in the CalcDisplay
            memory = System.Convert.ToString(Double.Parse(memory) - Double.Parse(CalcDisplay.Text));
        }

        private void TenPowerButton_Click(object sender, EventArgs e)
        {
            // sets the ShowOperation label to "10^ + the current number in the display
            ShowOperation.Text = System.Convert.ToString("10^" + Double.Parse(CalcDisplay.Text));
            //calculates 10 to power of the number in the CalcDisplay
            double tenPowerOf = Math.Pow(10.0, Double.Parse(CalcDisplay.Text));
            // sets the calc display equal to the tenPowerOf variable above
            CalcDisplay.Text = System.Convert.ToString(tenPowerOf);
        }

        private void RootButton_Click(object sender, EventArgs e)
        {
            // sets global results variable
            results = Double.Parse(CalcDisplay.Text);
            // clears CalcDisplay
            CalcDisplay.Text = "";
            // sets global operation variable to be root 
            operation = "√";
            // sets the ShowOperation label text to a string of the results variable + the operation text
            ShowOperation.Text = System.Convert.ToString(results) + "√";
        }

        private void FactorialButton_Click(object sender, EventArgs e)
        {
            // creates a variable equal to the number in the CalcDisplay
            double factorial = Double.Parse(CalcDisplay.Text);
            // creates a copy of the variable above which is used in the calculation
            double factorialResult = factorial;
            // sets the ShowOperation label to the number in the CalcDisplay + "!"
            ShowOperation.Text = System.Convert.ToString(CalcDisplay.Text + "!");
            // loops
            for (double i = 1.0; i < factorial; i++)
            {
                // multiple the factorialResult variable by i
                factorialResult = factorialResult * i;
            }
            // set CalcDisplay equal to the final result of factorialResult
            CalcDisplay.Text = System.Convert.ToString(factorialResult);
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            // takes the CalcDisplay string and converts to a double 
            results = Double.Parse(CalcDisplay.Text);
            // clears CalcDisplay
            CalcDisplay.Text = "";
            // sets global operation variable to be power 
            operation = "^";
            // sets the ShowOperation label text to a string of the results variable + the operation text
            ShowOperation.Text = System.Convert.ToString(results) + "^";
        }
    }
}
