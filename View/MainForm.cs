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
            var calculator = new global::Calculator.Calculator();
            calculator.Calculate("45-(-15)+5/(10*2+5)");
            MessageBox.Show(calculator.Result.ToString());
        }
    }
}