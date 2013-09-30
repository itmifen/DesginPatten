using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  public  class SuperUsers:Iusers
    {
        public void AddGoods()
        {
            Console.WriteLine("超级用户添加商品");
        }

        public void ManagerGoods()
        {
            Console.WriteLine("超级用户管理商品");
        }

        public void ManagerOrders()
        {
            Console.WriteLine("超级用户管理订单");
        }
    }
}
