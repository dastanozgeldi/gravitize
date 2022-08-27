using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gravitize
{
    public partial class Calculator : Form
    {
        // Gravitational Constant
        public const double G = 6.67e-11;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Every field is empty
            if (string.IsNullOrEmpty(textBox1.Text) &&
                string.IsNullOrEmpty(textBox2.Text) &&
                string.IsNullOrEmpty(textBox3.Text) &&
                string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show(
                    "Not enough data provided. Please fill at least 3 fields to get the job done.",
                    "Error!",
                    MessageBoxButtons.OK
                );
                return;
            }

            double m1, m2, R, F, g;

            try
            {
                m1 = Convert.ToDouble(textBox1.Text);
                m2 = Convert.ToDouble(textBox2.Text);
                R = Convert.ToDouble(textBox3.Text);
                // Gravitational Force Formula
                F = G * m1 * m2 / R * R;
                // Acceleration of Free Fall Formula
                g = G * m1 / R * R;
                // Displaying the results.
                textBox4.Text = F.ToString();
                textBox5.Text = g.ToString();
            } catch (FormatException)
            {
                MessageBox.Show(
                    "One of the fields was given a non-number. Please make sure to pass numbers in all 3 fields.",
                    "Error!",
                    MessageBoxButtons.OK
                );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Creating a confirmation dialog since a user may accidentally click "Clear" button and lose all their inputs.
            var confirm = MessageBox.Show(
                "Are you sure you want to clear all data?",
                "Confirmation Window",
                MessageBoxButtons.YesNo
            );
            // User clicked "Yes".
            if (confirm == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // Hide current window and show the main menu window.
            Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = Properties.Resources.Explanation;
        }
    }
}
