using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    
    class Context
    {
        Iusers iuser;
        public Context(Iusers iuser)
        {
            this.iuser = iuser;
        }

        public Context(int i)
        {
            switch (i)
            { 
                case 1:
                    iuser = new CommonUsers();
                    break;
                case 2:
                    iuser = new GoldUsers();
                    break;
                case 3:
                    iuser = new SuperUsers();
                    break;
            }
        }

        public void ContextAddGoods() {
            iuser.AddGoods();
        }

        public void ContextManagerGoods()
        {
            iuser.ManagerGoods();
        }

        public void ContextManagerOrders()
        {
            iuser.ManagerOrders();
        }
    }
}
