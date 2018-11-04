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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public List<ordertest.Order> orderList1 = new List<ordertest.Order>();
        public List<ordertest.Order> orderList2 = new List<ordertest.Order>();
        public List<ordertest.Order> orderList3 = new List<ordertest.Order>();
        public List<ordertest.Order> orderList4 = new List<ordertest.Order>();
        public List<ordertest.Order> ListTemp = new List<ordertest.Order>();

        private void button1_Click(object sender, EventArgs e)
        {
            string temp1 = textBox1.Text;
            long temp2 = long.Parse(temp1);
            ordertest.Order Info1 = new ordertest.Order(2018001, "apple", "Wang", 101011);
            ordertest.Order Info2 = new ordertest.Order(2018002, "melon", "Chen", 205025);
            ordertest.Order Info3 = new ordertest.Order(2018003, "groups", "Shen", 563442);
            orderList1.Add(Info1);
            orderList1.Add(Info2);
            orderList1.Add(Info3);
            ordertest.OrderDetails fun1 = new ordertest.OrderDetails(1);
            ListTemp = fun1.SearchByOrderNum(orderList1, temp2);
            foreach (var n in ListTemp)
            {
                orderList1.Remove(n);
            }
            dataGridView1.DataSource = orderList1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordertest.Order Info1 = new ordertest.Order(2018001, "apple", "Wang", 101011);
            ordertest.Order Info2 = new ordertest.Order(2018002, "melon", "Chen", 205025);
            ordertest.Order Info3 = new ordertest.Order(2018003, "groups", "Shen", 563442);
            orderList2.Add(Info1);
            orderList2.Add(Info2);
            orderList2.Add(Info3);
            ordertest.OrderDetails fun1 = new ordertest.OrderDetails(1);
            ListTemp = fun1.SearchByGoodsName(orderList2,textBox2.Text);
            foreach (var n in ListTemp)
            {
                orderList2.Remove(n);
            }
            dataGridView2.DataSource = orderList2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ordertest.Order Info1 = new ordertest.Order(2018001, "apple", "Wang", 101011);
            ordertest.Order Info2 = new ordertest.Order(2018002, "melon", "Chen", 205025);
            ordertest.Order Info3 = new ordertest.Order(2018003, "groups", "Shen", 563442);
            orderList3.Add(Info1);
            orderList3.Add(Info2);
            orderList3.Add(Info3);
            ordertest.OrderDetails fun1 = new ordertest.OrderDetails(1);
            ListTemp = fun1.SearchByGoodsName(orderList3, textBox3.Text);
            foreach (var n in ListTemp)
            {
                orderList3.Remove(n);
            }
            dataGridView3.DataSource = orderList3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string temp1 = textBox1.Text;
            long temp2 = long.Parse(temp1);
            ordertest.Order Info1 = new ordertest.Order(2018001, "apple", "Wang", 101011);
            ordertest.Order Info2 = new ordertest.Order(2018002, "melon", "Chen", 205025);
            ordertest.Order Info3 = new ordertest.Order(2018003, "groups", "Shen", 563442);
            orderList4.Add(Info1);
            orderList4.Add(Info2);
            orderList4.Add(Info3);
            ordertest.OrderDetails fun1 = new ordertest.OrderDetails(1);
            ListTemp = fun1.SearchByOrderNum(orderList4, temp2);
            foreach (var n in ListTemp)
            {
                orderList4.Remove(n);
            }
            dataGridView4.DataSource = orderList4;
        }
    }
    
}
