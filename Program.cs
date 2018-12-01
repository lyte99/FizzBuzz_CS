using System;

namespace FIzzBuzz_CS
{
    class Program
    {
        static void Main(string[] args)
        {
             //FIZZBUZZ!
            for  (int i=0;i<101;i++)
            {
                if (i % 3 == 0 && i % 5 == 0 )
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0 )
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 )
                {
                   Console.WriteLine("Buzz") ;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
