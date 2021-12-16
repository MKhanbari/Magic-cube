using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MajicCube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {if (numericUpDown1.Value >= 20 && numericUpDown1.Value <= 100)
            {
                label3.Text = Convert.ToString(numericUpDown1.Value - 20);
                label9.Text = Convert.ToString(numericUpDown1.Value - 20 - 1);
                label12.Text = Convert.ToString(numericUpDown1.Value - 20 + 2);
                label14.Text = Convert.ToString(numericUpDown1.Value - 20 + 1);
                label2.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = label8.Visible = label9.Visible = label10.Visible = label11.Visible = label13.Visible = label14.Visible = label12.Visible = label15.Visible = label17.Visible = label16.Visible = true;
            }
        else
            {
                MessageBox.Show("You are out of yhr ringe");
            }
        
        }
    }
}
