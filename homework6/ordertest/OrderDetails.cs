using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace ordertest
{
    public class OrderDetails
    {
        private int num;

        public OrderDetails(int n)
        {
            num = n;
        }



        public List<Order> SearchByGoodsName(List<Order> OrderList)//按照订单商品名称查找相应订单
        {
            var m = from n in OrderList where n.GoodsName == "melon" select n;
            foreach (var n in m)
            {
                Console.WriteLine(n);
            }
            return m as List<Order>;
        }
        public List<Order> SearchByCustomer(List<Order> OrderList)
        {
            var m = from n in OrderList where n.Customer == "Chen" select n;
            foreach (var n in m)
            {
                Console.WriteLine(n);
            }
            return m as List<Order>;
        }
        public List<Order> SearchByOrderNum(List<Order> OrderList)
        {
            var m = from n in OrderList where n.OrderNum == 2018002 select n;
            foreach (var n in m)
            {
                Console.WriteLine(n);
            }
            return m as List<Order>;
        }
        public List<Order> SearchByOrderamount(List<Order> OrderList)
        {
            var m = from n in OrderList where n.Orderamount > 500000 select n;
            foreach (var n in m)
            {
                Console.WriteLine(n);
            }
            return m as List<Order>;
        }

        public void Export(List<Order> OrderList)
        {

            XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("Order.xml", FileMode.Create))
            {
                xs.Serialize(fs, OrderList);
            }
        }
        public void Import(List<Order> OrderList)
        {
            using (FileStream fs = new FileStream("Order.xml", FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
                List<Order> OrderList2 = (List<Order>)xs.Deserialize(fs);
                OrderList2.ForEach(ORDER => Console.WriteLine(ORDER.ToString()));
            }
        }


    }
}


//**************************************************************************************************************
//以下为上次作业

//    public void DelInfo1(int Num)//按照订单号查询到相应订单并删除
//    {
//        foreach(Order temp in OrderList)
//        {
//            if(temp.OrderNum==Num)
//                OrderList.Remove(temp);
//           else if (temp.OrderNum == 0)
//                Console.WriteLine("没有查找到订单号，不存在该订单，删除失败！");//没有查询到相应的订单，删除失败
//        }   
//    }
//    public void DelInfo2(string name)//按照订单商品种类查询到订单信息，并删除
//    {
//        foreach (Order temp in OrderList)
//        {
//            if (temp.GoodsName == name)
//                OrderList.Remove(temp);
//           else if (temp.GoodsName == "" )
//                Console.WriteLine("没有查找到该订单名称，不存在该订单，删除失败！");//没有查询到相应的订单，删除失败
//        }
//    }
//    public void DelInfo3(string cus)//按照订单客户的姓名查询到订单，并删除
//    {
//        foreach (Order temp in OrderList)
//        {
//            if (temp.Customer == cus)
//                OrderList.Remove(temp);
//            else if (temp.Customer == "")
//                Console.WriteLine("没有查找到该订单客户，不存在该订单，删除失败！");//没有查询到相应的订单，删除失败
//        }
//    }
//    public void Add(Order Info)//添加新订单，此前应该要对新订单进行初始化
//    {
//        OrderList.Add(Info);
//    }
//    public void FindOrder1(long Num)
//    {
//        foreach(Order temp in OrderList)//按照订单号查询相应订单
//        {
//            if (temp.OrderNum == Num)
//                Console.WriteLine(temp);
//            else if (temp.OrderNum == 0)//查询完所有订单，但没有查到相应订单
//                Console.WriteLine("没有查询到该订单号，不存在此订单！");
//        }
//    }
//    public void FindOrder2(string kind)
//    {
//        foreach (Order temp in OrderList)//按照订单商品种类查询订单信息
//        {
//            if (temp.GoodsName == kind)
//                Console.WriteLine(temp);
//            else if (temp.GoodsName == "")//查询完所有订单，但没有查到相应订单
//                Console.WriteLine("没有查询到该商品，不存在此订单！");
//        }
//    }
//    public void FindOrder3(string cus)
//    {
//        foreach (Order temp in OrderList)//按照订单客户姓名查找订单信息
//        {
//            if (temp.Customer == cus)
//                Console.WriteLine(temp);
//            else if (temp.Customer == "")//查询完所有订单，但没有查到相应订单
//                Console.WriteLine("没有查询到该客户，不存在此订单！");
//        }
//    }
//    public void rewrite1 (long Num1,long Num2 ,int L)//按照订单号查询订单，并修改该订单
//    {
//        for (int i=0;i<L; i++)
//        {
//            if (OrderList[i].OrderNum == Num1) OrderList[i].OrderNum = Num2;
//            else if (i == L && OrderList[i].OrderNum != Num1) Console.WriteLine("修改订单号失败，没有此订单！");//没有查询到订单，报错！
//        }
//    }
//    public void rewrite2(string Nam1, string Nam2, int L)//按照订单种类查询订单，并修改订单商品种类
//    {
//        for (int i = 0; i < L; i++)
//        {
//            if (OrderList[i].GoodsName == Nam1) OrderList[i].GoodsName = Nam2;
//            else if (i == L && OrderList[i].GoodsName != Nam1) Console.WriteLine("修改订单商品种类失败，没有此订单！");//没有查询到订单，报错！
//        }
//    }
//    public void rewrite3(string cus1, string cus2, int L)//按照订单客户姓名查询订单，并修改客户姓名
//    {
//        for (int i = 0; i < L; i++)
//        {
//            if (OrderList[i].Customer == cus1) OrderList[i].Customer = cus2;
//            else if (i == L && OrderList[i].Customer != cus1) Console.WriteLine("修改订单客户失败，没有此订单！");//没有查询到订单，报错！
//        }
//    }
//}


