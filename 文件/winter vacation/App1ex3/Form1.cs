using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string uName = Microsoft.VisualBasic.Interaction.InputBox("請輸入姓名", "輸入");
            DialogResult dr = MessageBox.Show(uName + "歡迎您!", "歡迎", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int w = Convert.ToInt32(textBox1.Text);
                int h = Convert.ToInt32(textBox2.Text);

                textBox3.Text = Convert.ToString(w * h * 0.3025) + "坪";

            }
            catch

            {
                MessageBox.Show("請輸入寬和長度!", "注意",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
