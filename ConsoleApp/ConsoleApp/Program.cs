using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Car car1 = new Mazda(1500, 4000);
            Car car2 = new Toyota(2000, 3000);

            try
            {
                a = car1.summ();
                b = car2.summ();
                if ((a | b) > 5000) throw new Exception();
            }
            catch (Exception e)
            {
                Console.WriteLine("Too expensive");
            }
            finally
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            Console.Read();
        }
    }
}
