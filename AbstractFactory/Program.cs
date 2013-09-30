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
            Context context;
            context = new Context(new GoldUsers());
            context.ContextAddGoods();

            context = new Context(new CommonUsers());
            context.ContextManagerGoods();

            context = new Context(new SuperUsers());
            context.ContextManagerOrders();

            context = new Context(1);
            context.ContextManagerGoods();
        }
    }
}
