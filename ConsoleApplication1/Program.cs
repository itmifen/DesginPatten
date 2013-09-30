using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            UserFactory userfactory = new UserFactory();
            Iusers users = userfactory.CreatUserFactory(2);
            users.AddGoods();
            users.ManagerGoods();
            users.ManagerOrders();

        }
    }
}
