using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Side : IFastFood
    {
        public void Order()
        {
            Console.WriteLine("A side is a great choice");
        }
    }
}
