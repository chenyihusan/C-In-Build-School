using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vegetable = int.Parse(textBox1.Text)*30;
            int Driedbeans = int.Parse(textBox2.Text)*15;
            int Kelp= int.Parse(textBox3.Text)*15;
            int Meat= int.Parse(textBox4.Text)*40;
            int Total1 = (vegetable + Driedbeans + Kelp + Meat);
            label7.Text = Total1.ToString();
           

            label10.Text = "一千 一百 十元 一元";
            foreach (char number in label7.Text)
            {

                label9.Text += number+"\t";

            }


          
        }
    }
}
