using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork6;
using System;
using System.Collections.Generic;
using System.Text;
using iTextSharp.tool.xml.util;
using iText.IO.Util;

namespace HomeWork6.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        
        

        [TestMethod()]
        public void orderAddTest()
        {
            OrderService os = new OrderService();
            OrderDetails orderDetails1 = new OrderDetails("手机", 6999, "WHU", 0001, 6999, "cxk");
            OrderDetails orderDetails2 = new OrderDetails("笔记本电脑", 16999, "WHU", 0002, 16999, "cxk");
            OrderDetails orderDetails3 = new OrderDetails("游戏机", 3999, "WHU", 0003, 3999, "cxk");

            os.orderAdd(orderDetails1);
            os.orderAdd(orderDetails2);
            os.orderAdd(orderDetails3);

            LinkedList<OrderDetails> orders = new LinkedList<OrderDetails>();
            orders.AddLast(orderDetails1);
            orders.AddLast(orderDetails2);
            orders.AddLast(orderDetails3);
            CollectionAssert.Equals(os,orders);
        }

        [TestMethod()]
        public void orderDeleteTest()
        {
            OrderService os = new OrderService();
            OrderDetails orderDetails1 = new OrderDetails("手机", 6999, "WHU", 0001, 6999, "cxk");
            OrderDetails orderDetails2 = new OrderDetails("笔记本电脑", 16999, "WHU", 0002, 16999, "cxk");
            OrderDetails orderDetails3 = new OrderDetails("游戏机", 3999, "WHU", 0003, 3999, "cxk");

            os.orderAdd(orderDetails1);
            os.orderAdd(orderDetails2);
            os.orderAdd(orderDetails3);
            os.orderDelete(0003);

            LinkedList<OrderDetails> orders = new LinkedList<OrderDetails>();
            orders.AddLast(orderDetails1);
            orders.AddLast(orderDetails2);
            CollectionAssert.Equals(os, orders);
        }

        [TestMethod()]
        public void orderUpdateTest()
        {
            OrderService os = new OrderService();
            OrderDetails orderDetails1 = new OrderDetails("手机", 6999, "WHU", 0001, 6999, "cxk");
            OrderDetails orderDetails2 = new OrderDetails("笔记本电脑", 16999, "WHU", 0002, 16999, "cxk");
            OrderDetails orderDetails3 = new OrderDetails("游戏机", 3999, "WHU", 0003, 3999, "cxk");
            OrderDetails orderDetails4 = new OrderDetails("游戏机", 3999, "wuzhishan", 0003, 3999, "swk");

            string[] s = {"swk" ,"wuzhishan"};
            
            os.orderAdd(orderDetails1);
            os.orderAdd(orderDetails2);
            os.orderAdd(orderDetails3);
            os.orderUpdate(0003,s);

            LinkedList<OrderDetails> orders = new LinkedList<OrderDetails>();
            orders.AddLast(orderDetails1);
            orders.AddLast(orderDetails2);
            orders.AddLast(orderDetails4);
            CollectionAssert.Equals(os, orders);
        }

        [TestMethod()]
        public void orderNumberQueryTest()
        {
            OrderService os = new OrderService();
            OrderDetails orderDetails1 = new OrderDetails("手机", 6999, "WHU", 0001, 6999, "cxk");
            OrderDetails orderDetails2 = new OrderDetails("笔记本电脑", 16999, "WHU", 0002, 16999, "cxk");
            OrderDetails orderDetails3 = new OrderDetails("游戏机", 3999, "WHU", 0003, 3999, "cxk");

            os.orderAdd(orderDetails1);
            os.orderAdd(orderDetails2);
            os.orderAdd(orderDetails3);
            List<OrderDetails> list = os.orderNumberQuery(0001);

            List<OrderDetails> result = new List<OrderDetails>();
            result.Add(orderDetails1);
            CollectionAssert.Equals(os, result);
        }

        [TestMethod()]
        public void goodsNameQueryTest()
        {
            OrderService os = new OrderService();
            OrderDetails orderDetails1 = new OrderDetails("手机", 6999, "WHU", 0001, 6999, "cxk");
            OrderDetails orderDetails2 = new OrderDetails("笔记本电脑", 16999, "WHU", 0002, 16999, "cxk");
            OrderDetails orderDetails3 = new OrderDetails("游戏机", 3999, "WHU", 0003, 3999, "cxk");

            os.orderAdd(orderDetails1);
            os.orderAdd(orderDetails2);
            os.orderAdd(orderDetails3);
            List<OrderDetails> list = os.goodsNameQuery("手机");

            List<OrderDetails> result = new List<OrderDetails>();
            result.Add(orderDetails1);
            CollectionAssert.Equals(os, result);
        }

        [TestMethod()]
        public void custmoerNameQueryTest()
        {
            OrderService os = new OrderService();
            OrderDetails orderDetails1 = new OrderDetails("手机", 6999, "WHU", 0001, 6999, "cxk");
            OrderDetails orderDetails2 = new OrderDetails("笔记本电脑", 16999, "WHU", 0002, 16999, "zs");
            OrderDetails orderDetails3 = new OrderDetails("游戏机", 3999, "WHU", 0003, 3999, "ls");

            os.orderAdd(orderDetails1);
            os.orderAdd(orderDetails2);
            os.orderAdd(orderDetails3);
            List<OrderDetails> list = os.custmoerNameQuery("cxk");

            List<OrderDetails> result = new List<OrderDetails>();
            result.Add(orderDetails1);
            CollectionAssert.Equals(os, result);
        }

        [TestMethod()]
        public void goodsMoneyQueryTest()
        {
            OrderService os = new OrderService();
            OrderDetails orderDetails1 = new OrderDetails("手机", 6999, "WHU", 0001, 6999, "cxk");
            OrderDetails orderDetails2 = new OrderDetails("笔记本电脑", 16999, "WHU", 0002, 16999, "cxk");
            OrderDetails orderDetails3 = new OrderDetails("游戏机", 3999, "WHU", 0003, 3999, "cxk");

            os.orderAdd(orderDetails1);
            os.orderAdd(orderDetails2);
            os.orderAdd(orderDetails3);
            List<OrderDetails> list = os.goodsMoneyQuery(6999);

            List<OrderDetails> result = new List<OrderDetails>();
            result.Add(orderDetails1);
            CollectionAssert.Equals(os, result);
        }
    }
}