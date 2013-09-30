using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  public  class GoldUsers:Iusers
    {
        public void AddGoods()
        {
            Console.WriteLine("金牌用户添加商品");
        }

        public void ManagerGoods()
        {
            Console.WriteLine("金牌用户管理商品");
        }

        public void ManagerOrders()
        {
            Console.WriteLine("金牌用户管理订单");
        }
    }
}
