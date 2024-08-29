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
            double num1 = Convert.ToDouble(txtBoxInput1.Text);
            double num2 = Convert.ToDouble(txtBoxInput2.Text);

            if (cbOperator.SelectedItem != null)
            {
                switch (cbOperator.SelectedItem.ToString())
                {
                    case "+":
                        cal.CalculateEvent += new Formula<double>(cal.GetSum);
                        lblDisplayTotal.Text = "Answer: " + cal.GetSum(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                        break;
                    case "-":
                        cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                        lblDisplayTotal.Text = "Answer: " + cal.GetDifference(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                        break;
                    case "*":
                        cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                        lblDisplayTotal.Text = "Answer: " + cal.GetProduct(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                        break;
                    case "/":
                        cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                        lblDisplayTotal.Text = "Answer: " + cal.GetQuotient(num1, num2).ToString();
                        cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                        break;
                    default:
                        MessageBox.Show("Please enter a valid operator.");
                        break;
                }
            }
        }
    }
}
