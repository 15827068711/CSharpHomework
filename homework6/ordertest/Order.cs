using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordertest
{
    [Serializable]
    public class Order//定义一个订单类，生成的对象中包含着订单的各类信息
    {
        private long orderNum;//订单号
        private string goodsname;//订单商品种类
        private string customer;//订单客户的姓名
        private long orderamount;
        private long phoneNum;
        public Order() { }
        public Order(long OrderNum, string GoodsName, string Customer, long Orderamount,long PhoneNum)//order类的构造函数
        {
            orderNum = OrderNum;
            goodsname = GoodsName;
            customer = Customer;
            orderamount = Orderamount;
            phoneNum = PhoneNum;
        }
        public Order(Order temp)
        {
            orderNum = temp.orderNum;
            orderamount = temp.orderamount;
            goodsname = temp.goodsname;
            customer = temp.customer;
            phoneNum = temp.phoneNum;
        }

        public long OrderNum//为类外部获得订单号提供一个接口
        {
            get { return orderNum; }
            set
            {
                if (value > 0)
                    orderNum = value;
                else
                    throw new ArgumentOutOfRangeException("oederNum error");
            }
        }
        public string GoodsName//为类外部获得订单商品种类提供一个接口
        {
            get { return goodsname; }
            set
            {
                if (value != " ")
                    goodsname = value;
                else
                    throw new ArgumentOutOfRangeException("goodsname error");
            }
        }
        public string Customer//为类外部获得订单客户姓名提供一个接口
        {
            get { return customer; }
            set
            {
                if (value != " ")
                    goodsname = value;
                else
                    throw new ArgumentOutOfRangeException("customer error");
            }
        }
        public long Orderamount
        {
            get { return orderamount; }
            set
            {
                if (value > 0)
                    orderamount = value;
                else
                    throw new ArgumentOutOfRangeException("orderamout error");
            }
        }
        public long PhoneNum
        {
            get { return phoneNum; }
            set
            {
                if (value > 0)
                    phoneNum = value;
                else
                    throw new ArgumentOutOfRangeException("orderamout error");
            }
        }
        public override string ToString()
        {
            return OrderNum + " " + GoodsName + " " + Customer + " " + orderamount;
        }
    }
}
