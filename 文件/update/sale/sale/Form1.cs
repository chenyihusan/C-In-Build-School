using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sale.Models;

namespace sale
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Data();

        }
        private void Data()
        {
            var context = new contucts();
            var list = context.SalesTable.ToList();
            var list2 = context.ProductsTable.ToList();

            var data = from s in list
                       join p in list2
                       on s.product equals p.product
                       select new Class1 { sale = s.Sales, product = s.product, price = s.number * p.price };
            dataGridView2.DataSource = list2;

       
          

            

            var total = data.GroupBy((x) => x.sale).Select((x) =>{return new  { Sale = x.Key, price = x.Sum(y => y.price) };});
            var best1 = total.FirstOrDefault((x) => x.price == total.Max((y) => y.price));
            dataGridView1.DataSource = total.ToList();
            label4.Text = best1.Sale; 


            var result = data.GroupBy((x) => x.product).Select((x) =>{return new { Item = x.Key, price = x.Sum((y) => y.price) };});

            dataGridView2.DataSource = result.ToList();
            var best = result.FirstOrDefault((x) => x.price == result.Max((y) => y.price));
            label6.Text = best.Item;

         
        }
        
    }
}
