
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] NumberOrder = { 10, 50, 30, 40 };
            string[] StringOrder = {"apple","cat","ball"};
            Double[] DoubleOrder = {40.22,30.20,50.20};



            MaxNumber.print(NumberOrder);
            MaxNumber.print(StringOrder);
            MaxNumber.print(DoubleOrder);



        }


    }
}
