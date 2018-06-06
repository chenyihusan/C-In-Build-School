using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //calculate();

        }
        public void calculate()
        {
            int input;
            input = int.Parse(textBox1.Text);
            int Chu = input * 4 + 350;
            int Fet = input * 3 + 400;
            int Taw = input * 2 + 500;
            int min = Math.Min(Chu, Math.Min(Fet, Taw));
            label3.Text = textBox1.Text+"分鐘";
            label6.Text = min.ToString() + "元";
            if (min == Chu)
            { label5.Text = "中華電信"; }
            else if (min == Fet)
            { label5.Text = "遠傳電信"; }
            else
            { label5.Text = "台灣大哥大"; }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate();
        }
    }
}
