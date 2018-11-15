using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ordertest;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public List<Order> orderList1 = new List<Order>();
        public List<Order> orderList2 = new List<Order>();
        public List<Order> orderList3 = new List<Order>();
        public List<Order> orderList4 = new List<Order>();
        public List<Order> ListTemp = new List<Order>();


        private void button1_Click(object sender, EventArgs e)
        {
            string temp1 = textBox1.Text;
            long temp2 = long.Parse(temp1);
            Order Info1 = new Order(2018001, "apple", "Wang", 101011, 13811112222);
            Order Info2 = new Order(2018002, "melon", "Chen", 205025, 15877775555);
            Order Info3 = new Order(2018003, "groups", "Shen", 563442, 15963214444);
            orderList1.Add(Info1);
            orderList1.Add(Info2);
            orderList1.Add(Info3);
            OrderDetails fun1 = new OrderDetails(1);
            ListTemp = fun1.SearchByOrderNum(orderList1, temp2);          
            orderBindingSource.DataSource = ListTemp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Order Info1 = new Order(2018001, "apple", "Wang", 101011, 13811112222);
            Order Info2 = new Order(2018002, "melon", "Chen", 205025, 15877775555);
            Order Info3 = new Order(2018003, "groups", "Shen", 563442, 15963214444);
            orderList2.Add(Info1);
            orderList2.Add(Info2);
            orderList2.Add(Info3);
            OrderDetails fun2 = new OrderDetails(1);
            orderList2 = fun2.SearchByGoodsName(orderList2, textBox2.Text);
            dataGridView2.DataSource = null;//初始化控件数据
            dataGridView2.DataSource = orderList2;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order Info1 = new Order(2018001, "apple", "Wang", 101011,13811112222);
            Order Info2 = new Order(2018002, "melon", "Chen", 205025, 15877775555);
            Order Info3 = new Order(2018003, "groups", "Shen", 563442, 15963214444);
            orderList3.Add(Info1);
            orderList3.Add(Info2);
            orderList3.Add(Info3);
            OrderDetails fun3 = new OrderDetails(1);
            orderList3 = fun3.SearchByCustomer(orderList3, textBox3.Text);
            this.dataGridView3.DataSource = null;//初始化控件数据
            this.dataGridView3.DataSource = this.orderList3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string temp1 = textBox4.Text;
            long temp2 = long.Parse(temp1);
            Order Info1 = new Order(2018001, "apple", "Wang", 101011, 13811112222);
            Order Info2 = new Order(2018002, "melon", "Chen", 205025, 15877775555);
            Order Info3 = new Order(2018003, "groups", "Shen", 563442, 15963214444);
            orderList4.Add(Info1);
            orderList4.Add(Info2);
            orderList4.Add(Info3);
            OrderDetails fun4 = new OrderDetails(1);
            orderList4 = fun4.SearchByOrderamount(orderList4, temp2);
            this.dataGridView4.DataSource = null;//初始化控件数据
            this.dataGridView4.DataSource = this.orderList4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string temp1 = textBox1.Text;
            long temp2 = long.Parse(temp1);
            Order Info1 = new Order(2018001, "apple", "Wang", 101011, 13811112222);
            Order Info2 = new Order(2018002, "melon", "Chen", 205025, 15877775555);
            Order Info3 = new Order(2018003, "groups", "Shen", 563442, 15963214444);
            orderList1.Add(Info1);
            orderList1.Add(Info2);
            orderList1.Add(Info3);
            OrderDetails fun1 = new OrderDetails(1);
            ListTemp = fun1.SearchByOrderNum(orderList1, temp2);
            foreach (var n in ListTemp)
            {
                orderList1.Remove(n);
            }
            dataGridView1.DataSource = orderList1;
        }
    }
}
