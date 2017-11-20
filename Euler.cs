using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            //*nie interesuje nas*//




            /*
            for (int a = 1; a <= 100; a++)
            {
                if (a % 2 == 0 || a%3 == 0)
                {
                    Console.Write(a + " " + a%2 +" " + "\n");
                }
            }
            */

            /* pierwsze zadanie euler
            int b = 0;
            for(int a = 1; a<1000; a++)
            {
                if (a % 3 == 0 || a % 5 == 0)
                {
                    Console.WriteLine(a);
                    b = b + a;
                }
            }
            Console.WriteLine("to jest ta suma " + b);
            */

            /* drugie zadanie
            int a = 1, b = 2, c, d = 2;
            while (true)
            {

                c = a + b;
                if (c >= 4000000) break;
                if (c % 2 == 0)
                {
                    Console.WriteLine(c);
                    d = d + c;

                }
                a = b; b = c;
               
            }
            Console.WriteLine(d);
         */


            /*
            int a = 0;
            a = 5 * 7 * 13 * 29;
            Console.WriteLine(a);
            */
            /* Obliczanie trawjące wieeeeeki
            long x = 600851475143;
            int f =5;
            for (long i=(x/2-1); i > 1; i--)
            {
                if (x % i == 0)
                {

                    for (long k = (i/2 - 1); k > 1; k--)
                    {
                        if (i % k == 0)
                        {
                            f = 1;
                            break;
                        }
                        else f = 0;
                    }
                    if (f == 0) { Console.WriteLine(i); break; }
                } 
            }
            */

            long x = 600851475143;
            int f = 5;
            for (long i = (x / 2 - 1); i > 1; i--)
            {
                
                if (x % i == 0)
                {Console.WriteLine(i);
                    for (int k=2;k*k<=i;k++)
                    {
                        if (i % k == 0)
                        {
                            f = 1;
                            break;
                        }
                        else f = 0;
                    }
                    if (f == 0) { Console.WriteLine(i); break; }
                }
            }



            Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
        }
    }
}
