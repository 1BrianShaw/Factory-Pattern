using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Burgers : IFastFood
    {
        public void Order()
        {
            Console.WriteLine("Burger is a great choice");
        }
    }
}
