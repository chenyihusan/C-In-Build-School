﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            textBox1.Text += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
            textBox1.Text += button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += button10.Text;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if(radioButton1.Checked)
            {
                int C = int.Parse(textBox1.Text);

                label2.Text = ((C * 9.0) / 5.0 + 32).ToString()+"F";
            }
            if (radioButton2.Checked)
            {
                int F = int.Parse(textBox1.Text);
                label2.Text = (5.0 / 9.0 * (F - 32)).ToString() + "C";
                    


            }


        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text =" ";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
