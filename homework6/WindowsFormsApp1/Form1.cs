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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<ordertest.Order> orderList = new List<ordertest.Order>();
        private void button1_Click(object sender, EventArgs e)
        {
            ordertest.Order Info1 = new ordertest.Order(2018001, "apple", "Wang", 101011);
            ordertest.Order Info2 = new ordertest.Order(2018002, "melon", "Chen", 205025);
            ordertest.Order Info3 = new ordertest.Order(2018003, "groups", "Shen", 563442);
            orderList.Add(Info1);
            orderList.Add(Info2);
            orderList.Add(Info3);
            this.dataGridView1.DataSource = null;//初始化控件数据
            this.dataGridView1.DataSource = this.orderList;//将对象orderList中的数据与dataGridView中的数据进行绑定
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
}
