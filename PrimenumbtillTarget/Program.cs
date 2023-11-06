using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter target");
        int limit = int.Parse(Console.ReadLine());
        

        for (int i = 2; i <= limit; i++)    //dividend
        {
            bool IsPrimenum = true;
            for (int j = 2; j < i; j++)    //divisor
            {
                if (i % j == 0)
                {
                    IsPrimenum = false;
                    break;
                }

            }
            if (IsPrimenum)
            {

                Console.Write($" {i} ");
            }
           
        }





        Console.ReadLine();

    }
   
    
}