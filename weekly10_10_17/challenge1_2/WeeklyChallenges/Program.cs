using System;

namespace WeeklyChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            int userinput;
            //                                                  
            //Console.WriteLine("Hello World!"); very easy.  <- <- 

            // easy... | | |
                    // V V V
            Console.WriteLine("Enter a number!");
             userinput = Convert.ToInt32(Console.ReadLine());
            if (userinput < 10 ) {
                Console.WriteLine("This number is too small");
            } else {
                Console.WriteLine("This number is big enough");
            }
        }
    }
}
