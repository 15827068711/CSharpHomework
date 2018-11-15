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
using System.Xml;
using System.IO;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int count = 0;
        public List<Order> orderList = new List<Order>();
        private void button1_Click(object sender, EventArgs e)
        {
            Order Info1 = new Order(2018001, "apple", "Wang", 101011, 13811112222);
            Order Info2 = new Order(2018002, "melon", "Chen", 205025, 15877775555);
            Order Info3 = new Order(2018003, "groups", "Shen", 563442, 15963214444);
            orderList.Add(Info1);
            orderList.Add(Info2);
            orderList.Add(Info3);
            //this.dataGridView1.DataSource = null;//初始化控件数据
            //this.dataGridView1.DataSource = this.orderList;//将对象orderList中的数据与dataGridView中的数据进行绑定
            orderDetailsBindingSource.DataSource = orderList;
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
        //依次验证订单
        private void button5_Click(object sender, EventArgs e)
        {
            Order Info1 = new Order(2018001, "apple", "Wang", 101011, 13811112222);
            Order Info2 = new Order(2018002, "melon", "Chen", 205025, 15877775555);
            Order Info3 = new Order(2018003, "groups", "Shen", 563442, 15963214444);
            orderList.Add(Info1);
            orderList.Add(Info2);
            orderList.Add(Info3);
            Order o = (Order)orderDetailsBindingSource.Current;
            long temp = o.OrderNum;
            SearchByOrderNum(orderList, temp);
            if (count == 2)
                textBox1.Text = "订单号没有重复。";
            else
                textBox1.Text = "订单号有重复！！！请重新核实！";
            if (temp.ToString() == "")
                textBox2.Text = "订单号为空！！！";
            else
                textBox2.Text = "订单号不为空。";
        }
        public int SearchByOrderNum(List<Order> OrderList, long Num)
        {
            var m = from n in OrderList where n.OrderNum == Num select n;
            foreach (var n in m)
            {
                ++count;
            }
            return count;
        }
        public bool verifyOrderNum(long temp)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(temp.ToString(), @"^[201][0-9](0[1-9]|1[0-2])(0[1-9]|[1-2][0-9]|3[0-1])[0-9]{3}$");
        }
        public bool verifyOrderAmount(long temp)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(temp.ToString(), @"^[1]+[3,5]+\d{9}$");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Order Info1 = new Order(20180112001, "apple", "Wang", 101011, 13811112222);
            Order Info2 = new Order(20180112002, "melon", "Chen", 205025, 15877775555);
            Order Info3 = new Order(20180112003, "groups", "Shen", 563442, 15963214444);
            orderList.Add(Info1);
            orderList.Add(Info2);
            orderList.Add(Info3);
            Order o = (Order)orderDetailsBindingSource.Current;
            XmlTextWriter writer;
            writer = new XmlTextWriter("orderInformation.xml", null);
            //为使文件易读 使用缩进
            writer.Formatting = Formatting.Indented;
            //写XML声明
            writer.WriteStartDocument();

            //引用样式
            String PItext = "type='text/xsl'href ='order.xsl'";
            writer.WriteProcessingInstruction("xml-stylesheet", PItext);

            //写入一个元素（根元素）
            writer.WriteStartElement("order");

            //属性
            writer.WriteAttributeString("genere", "order of fruit");

            //写入orderNum
            writer.WriteElementString("orderNum", o.OrderNum.ToString());

            //写入goodsName
            writer.WriteElementString("goodsName", o.GoodsName);

            //写入customer
            writer.WriteElementString("customer", o.Customer);

            //写入orderAmount
            writer.WriteElementString("orderAmount", o.Orderamount.ToString());

            //写入phoneNum
            writer.WriteElementString("phoneNum", o.PhoneNum.ToString());

            //关闭根元素
            writer.WriteEndElement();
            writer.WriteEndDocument();

            writer.Flush();
            writer.Close();

            transfer();


        }
        public static void transfer()
        {

            XslCompiledTransform trans = new XslCompiledTransform();
            trans.Load(@"orderInformation.xsl");
            trans.Transform(@"orderInformation.xml", "out.html");

        }

    }
}
        //public void CreateXmlFile()
        //{
           
        //    {

        //        XmlDocument xmlDoc = new XmlDocument();
        //        //创建类型声明节点    
        //        XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
        //        xmlDoc.AppendChild(node);


        //        List<Order> clist = new List<Order>();
        //        clist = con.CP.ToList();
        //        int ii = clist.Count;
        //        //创建根节点    
        //        XmlNode root = xmlDoc.CreateElement("User");

        //        xmlDoc.AppendChild(root);
        //        for (int i = 0; i < ii; i++)
        //        {
        //            CreateNode(xmlDoc, root, "Ids", clist[i].Ids.ToString());
        //            CreateNode(xmlDoc, root, "Id", clist[i].ID.ToString()); CreateNode(xmlDoc, root, "PC", clist[i].PJ.ToString());
        //        }
        //        try
        //        {
        //            xmlDoc.Save("c://data2.xml");
        //        }
        //        catch (Exception e)
        //        {
        //            //显示错误信息    
        //            Console.WriteLine(e.Message);
        //        }
        //        //Console.ReadLine();    

        //    }
        //}
        ///// <summary>      
        ///// 创建节点               /// </summary>      
        ///// <param name="xmldoc"></param>  xml文档    
        ///// <param name="parentnode"></param>父节点     
        ///// <param name="name"></param>  节点名             /// <param name="value"></param>  节点值    
        /////     
        //public void CreateNode(XmlDocument xmlDoc, XmlNode parentNode, string name, string value)
        //{
        //    XmlNode node = xmlDoc.CreateNode(XmlNodeType.Element, name, null);
        //    node.InnerText = value;
        //    parentNode.AppendChild(node);
        //
