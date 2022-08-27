using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Gravitize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(Properties.Resources.Author);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Calculator calc = new Calculator();
            calc.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(Properties.Resources.LaunchScript);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
