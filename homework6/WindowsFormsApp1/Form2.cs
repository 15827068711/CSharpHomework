using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private List<ordertest.Order> orderList = new List<ordertest.Order>();
        private List<ordertest.Order> ListT = new List<ordertest.Order>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            string temp1 = textBox1.Text;
            long temp2 = long.Parse(temp1);
            ordertest.Order Info1 = new ordertest.Order(2018001, "apple", "Wang", 101011);
            ordertest.Order Info2 = new ordertest.Order(2018002, "melon", "Chen", 205025);
            ordertest.Order Info3 = new ordertest.Order(2018003, "groups", "Shen", 563442);
            orderList.Add(Info1);
            orderList.Add(Info2);
            orderList.Add(Info3);
            ordertest.OrderDetails fun1 = new ordertest.OrderDetails(1);
            orderList= fun1.SearchByOrderNum(orderList, temp2);
            this.dataGridView1.DataSource = null;//初始化控件数据
            this.dataGridView1.DataSource = this.orderList;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordertest.Order Info1 = new ordertest.Order(2018001, "apple", "Wang", 101011);
            ordertest.Order Info2 = new ordertest.Order(2018002, "melon", "Chen", 205025);
            ordertest.Order Info3 = new ordertest.Order(2018003, "groups", "Shen", 563442);
            orderList.Add(Info1);
            orderList.Add(Info2);
            orderList.Add(Info3);
            ordertest.OrderDetails fun2 = new ordertest.OrderDetails(1);
            orderList = fun2.SearchByGoodsName(orderList, textBox2.Text);
            orderDetailsBindingSource.DataSource = orderList;
            this.dataGridView1.DataSource = null;//初始化控件数据
            this.dataGridView1.DataSource = this.orderList;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ordertest.Order Info1 = new ordertest.Order(2018001, "apple", "Wang", 101011);
            ordertest.Order Info2 = new ordertest.Order(2018002, "melon", "Chen", 205025);
            ordertest.Order Info3 = new ordertest.Order(2018003, "groups", "Shen", 563442);
            orderList.Add(Info1);
            orderList.Add(Info2);
            orderList.Add(Info3);
            ordertest.OrderDetails fun3 = new ordertest.OrderDetails(1);
            orderList = fun3.SearchByCustomer(orderList, textBox3.Text);
            orderDetailsBindingSource.DataSource = orderList;
            this.dataGridView1.DataSource = null;//初始化控件数据
            this.dataGridView1.DataSource = this.orderList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string temp1 = textBox4.Text;
            long temp2 = long.Parse(temp1);
            ordertest.Order Info1 = new ordertest.Order(2018001, "apple", "Wang", 101011);
            ordertest.Order Info2 = new ordertest.Order(2018002, "melon", "Chen", 205025);
            ordertest.Order Info3 = new ordertest.Order(2018003, "groups", "Shen", 563442);
            orderList.Add(Info1);
            orderList.Add(Info2);
            orderList.Add(Info3);
            ordertest.OrderDetails fun4 = new ordertest.OrderDetails(1);
            orderList = fun4.SearchByOrderNum(orderList, temp2);
            this.dataGridView1.DataSource = null;//初始化控件数据
            this.dataGridView1.DataSource = this.orderList;
        }
    }
}
