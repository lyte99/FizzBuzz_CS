using System;

namespace FIzzBuzz_CS
{
    class Program
    {
        static void Main(string[] args)
        {
             //FIZZBUZZ
             
             //loop 0 through 100
            for  (int i=0;i<101;i++)
            {
                //print Fizz Buzz if mutliple of 3 and 5
                if (i % 3 == 0 && i % 5 == 0 )
                {
                    Console.WriteLine("Fizz Buzz");
                }
                //print Fizz if mutliple of 3
                else if (i % 3 == 0 )
                {
                    Console.WriteLine("Fizz");
                }
                //print Buzz  if a multiple of 5
                else if (i % 5 == 0 )
                {
                   Console.WriteLine("Buzz") ;  
                }
                //if not a mutliple of 3 or 5, just print the #
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
