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

        private void EqualsButton_Click(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
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

        private void Button_Click(object sender, EventArgs e)
        {
            // clears CalcDisplay if CalcDisplay.Text = "0" or enter_value == true
            if ((CalcDisplay.Text == "0") || (enter_value))
            {
                CalcDisplay.Text = "";
            }
            enter_value = false;

            // creates button object equal to the button clicked
            Button num = (Button)sender;

            // if button clicked is "."
            if (num.Text == ".")
            {
                // if CalcDisplay doesn't already have a period in it
                if (!CalcDisplay.Text.Contains("."))
                { 
                    // set CalcDisplay text to the current text + the text from the clicked button
                    CalcDisplay.Text = CalcDisplay.Text + num.Text;
                }
            }
            else
            {
                CalcDisplay.Text = CalcDisplay.Text + num.Text;
            }       
        }
    }
}
