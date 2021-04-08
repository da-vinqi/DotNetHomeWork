using System;
using System.Collections.Generic;

namespace HomeWork5
{

    class Program
    {
        static void Main(string[] args)
        {

            OrderDetails orderDetails1 = new OrderDetails("手机",6999,"WHU",0001,6999,"cxk");
            OrderDetails orderDetails2 = new OrderDetails("笔记本电脑", 16999, "WHU", 0002, 16999, "cxk");
            OrderDetails orderDetails3 = new OrderDetails("游戏机", 3999, "WHU", 0003, 3999, "cxk");

            OrderService orderService = new OrderService();
            orderService.orderAdd(orderDetails1);
            orderService.orderAdd(orderDetails2);
            orderService.orderAdd(orderDetails3);

            List<OrderDetails> orders = orderService.orderNumberQuery(0001);
            orders.ForEach(o => Console.WriteLine(o));

            orders = orderService.goodsNameQuery("游戏机");
            orders.ForEach(o => Console.WriteLine(o));
            Console.ReadKey();
        }
    }
}
