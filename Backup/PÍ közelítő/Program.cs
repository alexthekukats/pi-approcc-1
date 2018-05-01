using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1; // Leibniz-féle sor  // elég lassú
           double egy = 1;
           a = 1 - (egy / 3);
            //decimal q = 10000000000000000000;

           for (int i = 5; ; i += 2)
           {
               a += egy / i;
              i += 2;
               a -= egy / i;

               
               Console.WriteLine(Convert.ToDouble(a * 4));
               //Console.ReadKey();*/
               //Console.ReadKey();
           }
            //Console.WriteLine(a * 4);
            
        }
    }
}
