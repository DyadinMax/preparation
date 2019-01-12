using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    abstract public class Car
    {
        protected Car()
        {

        }

        protected int price;
        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        protected int service;
        public int Service
        {
            get
            {
                return service;
            }
            set
            {
                service = value;
            }
        }

        public abstract int summ();
    }
}
