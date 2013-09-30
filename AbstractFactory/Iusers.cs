using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface Iusers
    {
        /// <summary>
        /// 添加商品
        /// </summary>
        void AddGoods();

        /// <summary>
        /// 管理商品
        /// </summary>
        void ManagerGoods();

        /// <summary>
        /// 管理订单
        /// </summary>
        void ManagerOrders();
    }
}
