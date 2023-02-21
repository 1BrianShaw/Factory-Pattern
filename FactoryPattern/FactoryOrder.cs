using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class FactoryOrder
    {
        internal static IFastFood Order(string getOrder)
        {
            switch (getOrder.ToLower())
            {
                case "burger":
                    return new Burgers();


                case "drink":
                    return new Drink();

                case "side":
                    return new Side();

                default:
                    return new Burgers();



            }

        }
    }
   
}
