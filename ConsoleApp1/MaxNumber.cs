using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MaxNumber
    {

        public static void print<T>(T a, T b, T c) where T: IComparable
        {
            if((a.CompareTo(b)>0 && a.CompareTo(c) >= 0) ||
               (a.CompareTo(b) >= 0 && a.CompareTo(c) > 0)||
               (a.CompareTo(b) > 0 && a.CompareTo(c) >0))


            {
                Console.WriteLine("Maxnumber :" +a);
            }
            else if((b.CompareTo(c)>0 && b.CompareTo(a) >= 0)||
                (b.CompareTo(c) >= 0 && b.CompareTo(a) > 0)||
                (b.CompareTo(c) > 0 && b.CompareTo(a) > 0))
            {
                Console.WriteLine("Maxnumber :" +b);
            }
            else if((c.CompareTo(a)>0 && b.CompareTo(a)>=0)||
                (c.CompareTo(a) >= 0 && b.CompareTo(a) > 0)||
                (c.CompareTo(a) > 0 && b.CompareTo(a) > 0)) {

                Console.WriteLine("Maxnumber :" + c);
            }
            else
            {
                Console.WriteLine("All number are equal");
            }
        }
    }
}
