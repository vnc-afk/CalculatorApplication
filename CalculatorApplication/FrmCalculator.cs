namespace CalculatorApplication
{
    public partial class Form1 : Form
    {
        CalculatorClass cal;

        public Form1()
        {
            InitializeComponent();
            cal = new CalculatorClass();

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (cbOperator.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a operator.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            double num1, num2;

            // Validate input for the text boxes
            if (!double.TryParse(txtBoxInput1.Text, out num1))
            {
                MessageBox.Show("Please enter a valid number in the first input box.");
                return;
            }

            if (!double.TryParse(txtBoxInput2.Text, out num2))
            {
                MessageBox.Show("Please enter a valid number in the second input box.");
                return;
            }


            if (cbOperator.SelectedItem != null)
            {
                switch (cbOperator.SelectedItem.ToString())
                {
                    case "+":
                        cal.CalculateEvent += new Formula<double>(cal.GetSum);
                        lblDisplayTotal.Text = "Answer:   " + cal.GetSum(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                        break;
                    case "-":
                        cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                        lblDisplayTotal.Text = "Answer:   " + cal.GetDifference(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                        break;
                    case "*":
                        cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                        lblDisplayTotal.Text = "Answer:   " + cal.GetProduct(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                        break;
                    case "/":
                        cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                        lblDisplayTotal.Text = "Answer:   " + cal.GetQuotient(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                        break;
                    default:
                        MessageBox.Show("Please enter a valid operator.");
                        break;
                }

            }
        }

        // We add some validations for better system's flow

        private void txtBoxInput1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, decimal points, and control keys (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtBoxInput2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, decimal points, and control keys (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }
    }
}
