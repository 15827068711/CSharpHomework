﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        public List<ordertest.Order> orderList = new List<ordertest.Order>();
        ordertest.Order Info1 = new ordertest.Order(2018001, "apple", "Wang", 101011);
        ordertest.Order Info2 = new ordertest.Order(2018002, "melon", "Chen", 205025);
        ordertest.Order Info3 = new ordertest.Order(2018003, "groups", "Shen", 563442);
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            orderList.Add(Info1);
            orderList.Add(Info2);
            orderList.Add(Info3);
            Order InfoT = new Order();
            InfoT.Customer = textBox1.Text;
            InfoT.GoodsName = textBox2.Text;
            InfoT.Orderamount = 50000;
            InfoT.OrderNum = 2018004;
            orderList.Add(InfoT);

            dataGridView1.DataSource = orderList;
        }
    }
}
