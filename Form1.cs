using System;
using System.Windows.Forms;

namespace ScientificCal
{
    public partial class Form1 : Form
    {
        private double accumulator = 0;  // Stores the result of calculations
        private char lastOperation = '\0';  // Tracks the last operator used
        private bool isOperatorPressed = false; // Tracks if an operator was pressed

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for digit buttons (0-9)
        private void Number_Pressed(object sender, EventArgs e)
        {
            string number = (sender as Button).Text;

            // If operator was pressed, clear the display and reset flag
            if (isOperatorPressed)
            {
                output.Text = "0";
                isOperatorPressed = false;
            }

            // Update the display based on input number
            output.Text = output.Text == "0" ? number : output.Text + number;
        }

        // Event handler for operator buttons (+, -, *, /, =)
        private void Operator_Pressed(object sender, EventArgs e)
        {
            char operation = (sender as Button).Text[0];

            // If 'C' is pressed, reset the accumulator and display
            if (operation == 'C')
            {
                accumulator = 0;
                output.Text = "0";
                lastOperation = '\0';
                return;
            }

            double currentValue = double.Parse(output.Text);

            // Perform the last operation
            switch (lastOperation)
            {
                case '+':
                    accumulator += currentValue;
                    break;
                case '-':
                    accumulator -= currentValue;
                    break;
                case '×':
                    accumulator *= currentValue;
                    break;
                case '÷':
                    if (currentValue != 0)
                        accumulator /= currentValue;
                    else
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    accumulator = currentValue; // First input
                    break;
            }

            // Store the new operator
            lastOperation = operation;

            // If '=' is pressed, show the result, otherwise prepare for next input
            output.Text = operation == '=' ? accumulator.ToString() : "0";
            isOperatorPressed = true;
        }

        // Event handler for sine function
        private void sinBtn_Click(object sender, EventArgs e)
        {
            double inputValue = double.Parse(output.Text);
            output.Text = Math.Sin(DegreeToRadian(inputValue)).ToString();
        }

        // Event handler for cosine function
        private void cosBtn_Click(object sender, EventArgs e)
        {
            double inputValue = double.Parse(output.Text);
            output.Text = Math.Cos(DegreeToRadian(inputValue)).ToString();
        }

        // Event handler for tangent function
        private void tanBtn_Click(object sender, EventArgs e)
        {
            double inputValue = double.Parse(output.Text);
            output.Text = Math.Tan(DegreeToRadian(inputValue)).ToString();
        }

        // Event handler for logarithmic function (base 10)
        private void logBtn_Click(object sender, EventArgs e)
        {
            double inputValue = double.Parse(output.Text);
            if (inputValue > 0)
            {
                output.Text = Math.Log10(inputValue).ToString();
            }
            else
            {
                MessageBox.Show("Input must be greater than 0 for logarithm.");
            }
        }

        // Utility function to convert degrees to radians
        private double DegreeToRadian(double degree)
        {
            return degree * (Math.PI / 180);
        }

        // Event handler for when text changes in the output (optional handling)
        private void output_TextChanged(object sender, EventArgs e)
        {
            // Optional handling for text change events
        }
    }
}
