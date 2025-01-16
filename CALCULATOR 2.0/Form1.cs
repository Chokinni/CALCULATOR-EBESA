using System.Data;
using System.Linq.Expressions;

namespace CALCULATOR_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> expressions = new List<string>();
        string currentInput = "";

        private void btn1_Click(object sender, EventArgs e)
        {
            currentInput += "1";
            txtTotal.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            currentInput += "2";
            txtTotal.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            currentInput += "3";
            txtTotal.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            currentInput += "4";
            txtTotal.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            currentInput += "5";
            txtTotal.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            currentInput += "6";
            txtTotal.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            currentInput += "7";
            txtTotal.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            currentInput += "8";
            txtTotal.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            currentInput += "9";
            txtTotal.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            currentInput += "0";
            txtTotal.Text += "0";
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            //  allow adding a dot if currentInput is not empty and doesn't already contain a dot
            if (!string.IsNullOrEmpty(currentInput) && !currentInput.Contains("."))
            {
                currentInput += "."; // Add a dot to the current number
                txtTotal.Text += ".";  // Update the display
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            expressions.Add(currentInput); // Store the current number
            if (!string.IsNullOrEmpty(currentInput) && !currentInput.Contains("+"))
            {
                expressions.Add("+"); // Add the operator
                currentInput = ""; // Reset current input
                txtTotal.Text += " + ";
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            expressions.Add(currentInput); // Store the current number

            if (!string.IsNullOrEmpty(currentInput) && !currentInput.Contains("-"))
            {
                expressions.Add("-"); // Add the operator
                currentInput = ""; // Reset current input
                txtTotal.Text += " - ";
            }


        }

        private void button16_Click(object sender, EventArgs e)
        {

            expressions.Add(currentInput); // Store the current number
            if (!string.IsNullOrEmpty(currentInput) && !currentInput.Contains("*"))
            {
                expressions.Add("*"); // Add the operator
                currentInput = ""; // Reset current input
                txtTotal.Text += " * ";
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            expressions.Add(currentInput); // Store the current number

            if (!string.IsNullOrEmpty(currentInput) && !currentInput.Contains("/"))
            {
                expressions.Add("/"); // Add the operator
                currentInput = ""; // Reset current input
                txtTotal.Text += " / ";
            }

        }

        private void btnCLR_Click(object sender, EventArgs e)
        {
            expressions.Clear(); // Clear the expression list
            currentInput = ""; // Clear current input
            txtTotal.Clear(); // Clear the display
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            expressions.Add(currentInput); // Add the last number
            string expression = string.Join(" ", expressions); // Create a full expression string

            try
            {

                if (expression.Contains("0 / 0"))
                {
                    txtTotal.Text = "Undefined operation: 0 ÷ 0";
                    expressions.Clear();
                    currentInput = "";
                    return;
                }

                // Evaluate the expression with PEMDAS
                var result = new DataTable().Compute(expression, null);

                // Display the result
                txtTotal.Text = result.ToString();
            }
            catch (Exception)
            {
                // Show error message if the expression is invalid
                txtTotal.Text = "Undefined operation";


            }

            expressions.Clear(); // Clear the list for the next calculation
            currentInput = ""; // Reset current input
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                // Remove the last character from the current input
                currentInput = currentInput.Remove(currentInput.Length - 1);
            }
            else if (expressions.Count > 0)
            {
                // Remove the last operator or number if currentInput is empty
                expressions.RemoveAt(expressions.Count - 1);
            }

            // Update the display with the remaining expression and input
            string expression = string.Join(" ", expressions);

            if (currentInput != "")
            {
                expression += " " + currentInput;
            }

            txtTotal.Text = expression;
        }

        private void btnPluMin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                // Negate the current input
                double value = double.Parse(currentInput);
                value = -value;

                // Update currentInput and txtTotal
                currentInput = value.ToString();
                txtTotal.Text = string.Join(" ", expressions) + " " + currentInput;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentInput))
            {
                try
                {
                    double value = double.Parse(currentInput);

                    if (value < 0)
                    {
                        txtTotal.Text = "Invalid input for √"; // Negative number error
                        return;
                    }

                    currentInput = Math.Sqrt(value).ToString(); // Calculate square root
                    txtTotal.Text = currentInput; // Update display
                }
                catch
                {
                    txtTotal.Text = "Error in √ operation"; // Fallback error message
                }
            }
            else
            {
                txtTotal.Text = "Input a value"; // No input error
            }
        }
    }
}
