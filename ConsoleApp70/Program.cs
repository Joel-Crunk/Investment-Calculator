using System;

namespace ConsoleApp70
{ 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many interations (months or Years)? ");
            double Num2 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Original amount? ");
            double amountOriginal = Convert.ToDouble(Console.ReadLine());
            

            Console.WriteLine("What interst rate? ");
            double rate = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Amount added each interation? ");
            double increase = Convert.ToDouble(Console.ReadLine());


        double A = 0;
            for (int i = 0; i < Num2; i++)
            {
                
                 A = (A + amountOriginal) * rate + increase +A;

            }
            double b = A + amountOriginal;
           Console.WriteLine( b);
            
            

            
        }
    }
}
