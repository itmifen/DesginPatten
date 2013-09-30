using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
   public class UserFactory
    {
       public Iusers CreatUserFactory(int type)
       {
           Iusers iusers = null;
           switch (type)
           { 
               case 1:
                   iusers = new CommonUsers();
                   break;
               case 2:
                   iusers = new GoldUsers();
                   break;
               case 3:
                   iusers = new SuperUsers();
                   break;
           }
           return iusers;
       }
    }
}
