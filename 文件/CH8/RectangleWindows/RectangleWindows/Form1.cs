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

        private void ComputeButton_Click(object sender, EventArgs e)
        {
            int width = Convert.ToInt32(width_NumericUpDown.Value);
            int height = Convert.ToInt32(height_NumericUpDown.Value);
            RectangleLibrary.Rectangle rect = new RectangleLibrary.Rectangle() { Width = width, Height = height };
            RectangleOperation operation = new RectangleOperation();
            operation.Target = rect;
            int area = operation.ComputeArea();
            resultLabel.Text = $"長方形的面積為 {area}";

        }
    }
}
