using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MaxNumber
    {

        public static void print<T>(T[]  Order)
        {
            Array.Sort(Order);
            foreach (var item in Order)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Max number : {Order[Order.Length-1]}");

        }
    }
}
