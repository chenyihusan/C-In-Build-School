using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT44
{
    public partial class Form1 : Form
    {
        List<string> number;
        List<string> anser = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            while(anser.Count<4)
            {
                int number = rnd.Next(0, 10);
                if ((anser.Any((x)=>x==number.ToString())==false ))
                {
                   anser.Add(number.ToString());
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((anser[0].ToString() + anser[1].ToString() + anser[2].ToString() + anser[3]).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string number = textBox1.Text;
            int A = 0; 
            int B = 0;
            var intersect = anser.ToString().Intersect(number);

            B = intersect.Count();
            foreach (var i in intersect)
            {
                var indans =anser.IndexOf(i.ToString());
                if (anser[indans] == number[indans].ToString())
                {
                    A++;
                }
            }
            B = B - A;
            textBox2.Text += number+ A.ToString() + "A" + B.ToString() + "B";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }
    }
}
