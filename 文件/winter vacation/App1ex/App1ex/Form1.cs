using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1ex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnF2C_Click(object sender, EventArgs e)
        {
            try
            {
                double f = Convert.ToDouble(TxtInput.Text);
                double c = (f - 32) * 5 / 9;
                TxtAns.Text = c.ToString("f2") + "度";
               
            }
            catch
            {
                TxtAns.Text = "度數請數入數值!";
                TxtInput.Clear();

            }
            TxtInput.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtInput.MaxLength = 3;
            TxtAns.ReadOnly = true;
            TxtInput.TabIndex = 0;
        }
    }
}
