using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex23u
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Load";
            Width = 500;
            Height = 300;
            BackColor = Color.Yellow;
        }

        private void Form1_Activate(object sender, EventArgs e)
        {
            Text += ",Act";
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Text += ",Paint";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Text += ",Click";
            Width += 10;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            Text += ",Dclick";
        }
    }
}
