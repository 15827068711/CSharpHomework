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
    class Mainclass
    {
        static void Main(string[] args)
        {
            Order Info1 = new Order(2018001, "apple", "Wang", 101011, 13811112222);
            Order Info2 = new Order(2018002, "melon", "Chen", 205025, 15877775555);
            Order Info3 = new Order(2018003, "groups", "Shen", 563442, 15963214444);
            List<Order> OrderList = new List<Order>();
            OrderList.Add(Info1);
            OrderList.Add(Info2);
            OrderList.Add(Info3);
            List<Order> ListT = new List<Order>();
            ordertest.OrderDetails fun = new ordertest.OrderDetails(1);
            //ListT = fun.SearchByOrderNum(OrderList, 2018001);
            Console.WriteLine(ListT);

            //OrderDetails Detail = new OrderDetails(1);
            //Detail.Import(OrderList);
            //Detail.Export(OrderList);

        }
    }

}