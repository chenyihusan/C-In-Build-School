using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sale.Models;

namespace Sale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sales();
        }
        public void Sales()
        {
            ContactsTable data = new ContactsTable();
            
            {
                try
                {

                    data.SaleTable.Add(new SaleTable() { Sales = "Bill" ,Pen = 33, Pencil = 32, Eraser = 56, Ruler = 45, Whiteout = 33});
                    data.SaleTable.Add(new SaleTable() { Sales = "John", Pen = 77, Pencil = 33, Eraser = 68, Ruler = 45, Whiteout =  23});
                    data.SaleTable.Add(new SaleTable() { Sales = "David", Pen = 43, Pencil = 55, Eraser = 43, Ruler = 67, Whiteout = 65 });
                  
                    data.SaveChanges();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                dataGridView1.DataSource = data.SaleTable.ToList();

            }
        }
    }
}
