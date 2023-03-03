using System;
using System.Windows.Forms;
using Calculator;

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
            string strs = String.Empty;
            var converter = new ExpressionInPostfix("45 - (-15) + 5");
            converter.Convert();
            string[] mass = converter.PostfixExpression;
            UnaryMinusFinder.ReplaceUnaryMinus(mass);
            foreach (var str in mass)
            {
                strs += str;
            }
            MessageBox.Show(strs);
        }
    }
}