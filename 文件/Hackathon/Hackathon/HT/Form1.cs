using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT
{
    public partial class Form1 : Form
    {
        private int[] ans = new int[10];
        private string[] gnum = new string[10];
        private int tmp, r;
        private Random ran = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for (int i = 0; i < 10; i++)
            {
                r = ran.Next(0, 10 - i);
                tmp = ans[r];
                ans[r] = ans[9 - i];
                ans[9 - i] = tmp;
            }
            for (int j = 1; j <= 4; j++)
            {
                gnum[j] = "";
            
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Text = "目前輸入" + textBox1.TextLength.ToString();        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.MaxLength = 4;
            for (int i = 0; i < 10; i++)
            {
                ans[i] = i;
            }
            for (int i = 0; i < 10; i++)
            {
                r = ran.Next(0, 10 - i);
                tmp = ans[r];
                ans[r] = ans[9 - i];
                ans[9 - i] = tmp;
            }

        }
    }
}

