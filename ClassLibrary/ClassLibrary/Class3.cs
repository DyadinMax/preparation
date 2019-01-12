using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Toyota : Car
    {
        public Toyota(int a, int b)
        {
            this.Price = a;
            this.Service = b;
        }

        public override int summ()
        {
            return price + service;
        }
    }
}
