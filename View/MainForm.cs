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
            foreach (var str in ExpressionParser.Parse("-2 + 3 4*(2-3 )"))
            {
                strs += str;
            }
            MessageBox.Show(strs);
        }
    }
}