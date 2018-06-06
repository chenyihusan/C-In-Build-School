using HW6.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW6
{
    public partial class Form1 : Form
    {
        List<TicketTable> list = new List<TicketTable>();
        public Form1()
        {
            InitializeComponent();
            count();
        }
        private void count()
        {
            try
            {
                TicketModel context = new TicketModel();
                context.Database.ExecuteSqlCommand("TRUNCATE TABLE [TicketTable]");
                context.SaveChanges();


                context.TicketTable.Add(new TicketTable() { Id = 1,  Start = "台北", End = "新竹", Price = 177 });
                context.TicketTable.Add(new TicketTable() { Id = 2, Start = "台北", End = "台中", Price = 375 });
                context.TicketTable.Add(new TicketTable() { Id = 3, Start = "台北", End = "嘉義", Price = 598 });
                context.TicketTable.Add(new TicketTable() { Id = 4 ,Start = "台北", End = "台南", Price = 738 });
                context.TicketTable.Add(new TicketTable() { Id = 5 ,Start = "台北", End = "高雄", Price = 842 });
                context.TicketTable.Add(new TicketTable() { Id = 6 ,Start = "新竹", End = "台中", Price = 197 });
                context.TicketTable.Add(new TicketTable() { Id = 7 ,Start = "新竹", End = "嘉義", Price = 421 });
                context.TicketTable.Add(new TicketTable() { Id = 8 ,Start = "新竹", End = "台南", Price = 560 });
                context.TicketTable.Add(new TicketTable() { Id = 9, Start = "新竹", End = "高雄", Price = 755 });
                context.TicketTable.Add(new TicketTable() { Id = 10 ,Start = "台中", End = "嘉義", Price = 224 });
                context.TicketTable.Add(new TicketTable() { Id = 11, Start = "台中", End = "台南", Price = 363 });
                context.TicketTable.Add(new TicketTable() { Id = 12,Start = "台中", End = "高雄", Price = 469 });
                context.TicketTable.Add(new TicketTable() { Id = 14,Start = "嘉義", End = "高雄", Price = 245 });
                context.TicketTable.Add(new TicketTable() { Id = 13,Start = "嘉義", End = "台南", Price = 139 });
                context.TicketTable.Add(new TicketTable() { Id = 15,Start = "台南", End = "高雄", Price = 106 });
                context.SaveChanges();
                list = context.TicketTable.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
        }

            public class Start : IEqualityComparer<TicketTable>
        {
            public bool Equals(TicketTable x, TicketTable y)
            {
                return x.Start == y.Start;
            }

            public int GetHashCode(TicketTable obj)
            {
                return obj.Start.GetHashCode();

            }
            
        }
        public class End : IEqualityComparer<TicketTable>
        {
            public bool Equals(TicketTable x, TicketTable y)
            {
                return x.End == y.End;
            }

            public int GetHashCode(TicketTable obj)
            {
                return obj.End.GetHashCode();
            }
        }

        private void toSouthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (toSouthRadioButton.Checked)
            {
                var item = list.Distinct(new Start());
                startComboBox.DataSource = item.Select((x)=>x.Start).ToList();
                var item1 = list.Distinct(new End());
                endComboBox.DataSource = item.Select((x) => x.End).ToList();
            }

        }

        private void toNorthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (toNorthRadioButton.Checked)
            {
                var item2 = list.Distinct(new End());
                startComboBox.DataSource = item2.Select((x) => x.End).ToList();
                var item3 = list.Distinct(new Start());
                endComboBox.DataSource = item3.Select((x) => x.Start).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yy;
            string zz;
            yy = startComboBox.SelectedItem.ToString();
            zz = endComboBox.SelectedItem.ToString();
            var result = list.Where((x) => x.Start == yy && x.End == zz). Select((y)=>y.Price);
            decimal sum = 0;
            foreach (var result1 in result)
            {
                decimal p = result1;
                 if (checkBox1.Checked && checkBox2.Checked)
                { sum = Math.Ceiling(p * 2 * 0.81m); }
                else if (checkBox1.Checked)
                { sum = Math.Ceiling( p * 2 * 0.9m); }
               
                else if (checkBox2.Checked)
                { sum = Math.Ceiling(p * 0.9m); }
                else
                { sum = p; }
                label4.Text = sum.ToString();
               
            }

        }
    }
        

      
    }

