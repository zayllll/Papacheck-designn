using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           timer1 = new Timer();
           timer1.Interval = 7000;
           timer1.Tick += Timer1_Tick;
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
            timer1.Stop();

            Form2 form2 = new Form2();
            form2.Show();

            this.Hide();
        }


    }
}
