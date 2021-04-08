using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork5
{
    class OrderDetails : Order,IComparable
    {
        public string GoodsName { get; set; }
        public int GoodsMoney { get; set; }
        public string Address { get; set; }

        public OrderDetails(string goodsName,int goodsMoney, string address, int OrderNum, int TotalMon, string CustomerName)
            : base(OrderNum,  TotalMon, CustomerName)
        {
            this.GoodsName = goodsName;
            this.GoodsMoney = goodsMoney;
            this.Address = address;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override string ToString()
        {
            return "The goods are:"+this.GoodsName+"\n The money are:"+this.GoodsMoney+"\n The address is:"+this.Address;
        }

        int IComparable.CompareTo(object obj)
        {
            OrderDetails ord2 = obj as OrderDetails;
            if (ord2 == null) throw new ApplicationException();
            return this.OrderNumber.CompareTo(ord2.OrderNumber);
        }
    }
}
