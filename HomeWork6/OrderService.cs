using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace HomeWork6
{
    [Serializable]
    public class OrderService
    {
        private LinkedList<OrderDetails> OrderList = new LinkedList<OrderDetails> { };
        public OrderService() { }
        public void orderAdd(OrderDetails orderDetail)
        {
            OrderList.AddLast(orderDetail);
        }
        public void orderDelete(int OrderNumber)
        {
            LinkedListNode<OrderDetails> node = OrderList.First;
            while (node != null)
            {
                if (node.Value.OrderNumber == OrderNumber)
                {
                    OrderList.Remove(node);
                    break;
                }
                node = node.Next;
            }
            throw new ApplicationException();
        }
        public void orderUpdate(int OrderNumber, string[] nameOrAddress)
        {
            LinkedListNode<OrderDetails> node = OrderList.First;
            while (node != null)
            {
                if (node.Value.OrderNumber == OrderNumber)
                {
                    if (nameOrAddress[0] != null)
                        node.Value.CustomerName = nameOrAddress[0];
                    if (nameOrAddress[1] != null)
                        node.Value.Address = nameOrAddress[1];
                    break;
                }
                node = node.Next;
            }
            throw new ApplicationException();
        }
        public List<OrderDetails> orderNumberQuery(int OrderNumber)
        {
            var s = from order in OrderList
                    where order.OrderNumber == OrderNumber
                    orderby order.TotalMoney
                    select order;
            return s.ToList();
        }
        public List<OrderDetails> goodsNameQuery(string goodsName)
        {
            var s = from order in OrderList
                    where order.GoodsName == goodsName
                    orderby order.TotalMoney
                    select order;
            return s.ToList();
        }
        public List<OrderDetails> custmoerNameQuery(string customerName)
        {
            var s = from order in OrderList
                    where order.CustomerName == customerName
                    orderby order.TotalMoney
                    select order;
            return s.ToList();
        }
        public List<OrderDetails> goodsMoneyQuery(int goodsMoney)
        {
            var s = from order in OrderList
                    where order.GoodsMoney == goodsMoney
                    orderby order.TotalMoney
                    select order;
            return s.ToList();
        }



        public void Export()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderService));
            using (FileStream fs = new FileStream("demo.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, this);
            }
        }
        public static void Import()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(OrderService));
            using (FileStream fs = new FileStream("demo.xml", FileMode.Open))
            {
                OrderService os = (OrderService)xmlSerializer.Deserialize(fs);
            }
        }
    }
}
