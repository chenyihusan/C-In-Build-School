using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oil.Models;

namespace Oil
{
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            Data();
        }

        private void Data()
        {
            var context = new ContactsModel();
            var list = context.RefuleTable.ToList();
            DateTime Startdate = dateTimePicker1.Value;
            DateTime Enddate = dateTimePicker2.Value;
            List<RefuleTable> find = new List<RefuleTable>();
            foreach (var item in list)
            {
                if (Startdate <= item.RefulingDate && item.RefulingDate <= Enddate)
                {
                    find.Add(item);
                }
                dataGridView1.DataSource = find;
            }
            var liter = find.Sum((x) => x.Liter);
            var Kilometer = find.Sum((x) => x.Kilometer);
            label4.Text =(Kilometer / liter).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data();
        }
    }
}
