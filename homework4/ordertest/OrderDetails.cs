using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest
{
    class OrderDetails
    {
        static Order Info1 = new Order(2018001, "apple", "Wang");
        static Order Info2 = new Order(2018002, "melon", "Chen");
        static Order Info3 = new Order(2018003, "groups", "Shen");
        List<Order> OrderList = new List<Order>() { Info1, Info2, Info3 };//建立一个由order类对象组成的list

        public void DelInfo1(int Num)//按照订单号查询到相应订单并删除
        {
            foreach (Order temp in OrderList)
            {
                if (temp.OrderNum == Num)
                    OrderList.Remove(temp);
                else if (temp.OrderNum == 0)
                    Console.WriteLine("没有查找到订单号，不存在该订单，删除失败！");//没有查询到相应的订单，删除失败
            }
        }
        public void DelInfo2(string name)//按照订单商品种类查询到订单信息，并删除
        {
            foreach (Order temp in OrderList)
            {
                if (temp.GoodsName == name)
                    OrderList.Remove(temp);
                else if (temp.GoodsName == "")
                    Console.WriteLine("没有查找到该订单名称，不存在该订单，删除失败！");//没有查询到相应的订单，删除失败
            }
        }
        public void DelInfo3(string cus)//按照订单客户的姓名查询到订单，并删除
        {
            foreach (Order temp in OrderList)
            {
                if (temp.Customer == cus)
                    OrderList.Remove(temp);
                else if (temp.Customer == "")
                    Console.WriteLine("没有查找到该订单客户，不存在该订单，删除失败！");//没有查询到相应的订单，删除失败
            }
        }
        public void Add(Order Info)//添加新订单，此前应该要对新订单进行初始化
        {
            OrderList.Add(Info);
        }
        public void FindOrder1(long Num)
        {
            foreach (Order temp in OrderList)//按照订单号查询相应订单
            {
                if (temp.OrderNum == Num)
                    Console.WriteLine(temp);
                else if (temp.OrderNum == 0)//查询完所有订单，但没有查到相应订单
                    Console.WriteLine("没有查询到该订单号，不存在此订单！");
            }
        }
        public void FindOrder2(string kind)
        {
            foreach (Order temp in OrderList)//按照订单商品种类查询订单信息
            {
                if (temp.GoodsName == kind)
                    Console.WriteLine(temp);
                else if (temp.GoodsName == "")//查询完所有订单，但没有查到相应订单
                    Console.WriteLine("没有查询到该商品，不存在此订单！");
            }
        }
        public void FindOrder3(string cus)
        {
            foreach (Order temp in OrderList)//按照订单客户姓名查找订单信息
            {
                if (temp.Customer == cus)
                    Console.WriteLine(temp);
                else if (temp.Customer == "")//查询完所有订单，但没有查到相应订单
                    Console.WriteLine("没有查询到该客户，不存在此订单！");
            }
        }
        public void rewrite1(long Num1, long Num2, int L)//按照订单号查询订单，并修改该订单
        {
            for (int i = 0; i < L; i++)
            {
                if (OrderList[i].OrderNum == Num1) OrderList[i].OrderNum = Num2;
                else if (i == L && OrderList[i].OrderNum != Num1) Console.WriteLine("修改订单号失败，没有此订单！");//没有查询到订单，报错！
            }
        }
        public void rewrite2(string Nam1, string Nam2, int L)//按照订单种类查询订单，并修改订单商品种类
        {
            for (int i = 0; i < L; i++)
            {
                if (OrderList[i].GoodsName == Nam1) OrderList[i].GoodsName = Nam2;
                else if (i == L && OrderList[i].GoodsName != Nam1) Console.WriteLine("修改订单商品种类失败，没有此订单！");//没有查询到订单，报错！
            }
        }
        public void rewrite3(string cus1, string cus2, int L)//按照订单客户姓名查询订单，并修改客户姓名
        {
            for (int i = 0; i < L; i++)
            {
                if (OrderList[i].Customer == cus1) OrderList[i].Customer = cus2;
                else if (i == L && OrderList[i].Customer != cus1) Console.WriteLine("修改订单客户失败，没有此订单！");//没有查询到订单，报错！
            }
        }
    }
}
