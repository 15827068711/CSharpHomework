﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ordertest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest.Tests
{
    [TestClass()]
    public class OrderDetailsTests
    {
        Order Info1 = new Order(2018001, "apple", "Wang", 101011,15844445555);
        Order Info2 = new Order(2018002, "melon", "Chen", 205025,15844445555);
        Order Info3 = new Order(2018003, "groups", "Shen", 563442, 15844445555);
        List<Order> OrderList = new List<Order>();

        [TestMethod()]
        public void SearchByGoodsNameTest()
        {
            Order sample = new Order(2018002, "melon", "Chen", 205025, 15844445555);
            List<Order> OrderList = new List<Order>();
            OrderList.Add(sample);
            OrderDetails p = new OrderDetails(1);
            List<Order> OrderList1 = new List<Order>();
            OrderList1 = p.SearchByGoodsName(OrderList,"lemon");
            CollectionAssert.AreEqual(OrderList1, OrderList);
        }

        [TestMethod()]
        public void SearchByCustomerTest()
        {
            Order sample = new Order(2018002, "melon", "Chen", 205025, 15844445555);
            List<Order> OrderList = new List<Order>();
            OrderList.Add(sample);
            OrderDetails p = new OrderDetails(1);
            List<Order> OrderList1 = new List<Order>();
            OrderList1 = p.SearchByCustomer(OrderList,"Shen");
            CollectionAssert.AreEqual(OrderList1, OrderList);
        }

        [TestMethod()]
        public void SearchByOrderNumTest()
        {
            Order sample = new Order(2018002, "melon", "Chen", 205025, 15844445555);
            List<Order> OrderList = new List<Order>();
            OrderList.Add(sample);
            OrderDetails p = new OrderDetails(1);
            List<Order> OrderList1 = new List<Order>();
            OrderList1 = p.SearchByOrderNum(OrderList,2018001);
            CollectionAssert.AreEqual(OrderList1, OrderList);
        }

        [TestMethod()]
        public void SearchByOrderamountTest()
        {
            Order sample = new Order(2018003, "groups", "Shen", 563442, 15844445555);
            List<Order> OrderList = new List<Order>();
            OrderList.Add(sample);
            OrderDetails p = new OrderDetails(1);
            List<Order> OrderList1 = new List<Order>();
            OrderList1 = p.SearchByOrderamount(OrderList,50000);
            CollectionAssert.AreEqual(OrderList1, OrderList);
        }
    }
}