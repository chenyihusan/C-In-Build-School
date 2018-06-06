using RectangleLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RectangleWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int width = 0;
            Int32.TryParse(numericUpDown1.Value.ToString(),out width);
            var height = (int)numericUpDown2.Value;
            RectangleLibrary.Rectangle rect = new RectangleLibrary.Rectangle() { Width = width, Height = height };
            RectangleOperation operation = new RectangleOperation();
            operation.Target = rect;
            int area = operation.ComputeArea();
            label3.Text = area.ToString();
           


        }
    }
}
