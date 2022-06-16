using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {
        int vx;
        int vy;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vx += -5;
            vy += 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vx += 0; 
            vy += -5; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx += 5;
            vy += 0;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            vx += 0;
            vy += 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("章瑞謙");
            timer1.Enabled = false;
        }
        
    }
}
