using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extenssion_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation c=new Calculation();
            int resullt = c.square(2);
            Console.WriteLine(resullt);
            Console.WriteLine(c.multiply(15, 13));
        }
    }
}
