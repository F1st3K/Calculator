using System;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void _calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                var calculator = new global::Calculator.Calculator();
                calculator.Calculate(_inputExpression.Text);
                _inputExpression.Text = calculator.InfixExpression;
                _convertedExpression.Text = calculator.PosfixExpression;
                _resultExpression.Text = calculator.Result.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}