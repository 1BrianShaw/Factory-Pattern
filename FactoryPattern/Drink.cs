using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Drink : IFastFood
    {
        public void Order()
        {
            Console.WriteLine("A drink is a great choice");
        }
    }
}
