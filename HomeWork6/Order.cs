using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork6
{
    
        public class Order
        {
            public int OrderNumber { get; set; }
            public int TotalMoney { get; set; }
            public string CustomerName { get; set; }
            public Order(int OrderNum, int TotalMon, string CustomerName)
            {
                this.OrderNumber = OrderNum;
                this.TotalMoney = TotalMon;
                this.CustomerName = CustomerName;
            }
            public override int GetHashCode()
            {
                return this.OrderNumber;
            }
            public override bool Equals(object obj)
            {
                Order order = obj as Order;
                return order != null && order.CustomerName == this.CustomerName && order.OrderNumber ==
                    this.OrderNumber && order.TotalMoney == this.TotalMoney;
            }
            public override string ToString()
            {
                return "OrderNumber:" + this.OrderNumber + "\n TotalMoney:" + this.TotalMoney + "\n CustomerName:" + this.CustomerName;
            }
        }
    
}
