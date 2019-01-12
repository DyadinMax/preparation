using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mazda : Car
    {
        public Mazda(int a, int b)
        {
            this.Price = a;
            this.Service = b;
        }

        public override int summ()
        {
            return price + service/2;
        }
    }
}
