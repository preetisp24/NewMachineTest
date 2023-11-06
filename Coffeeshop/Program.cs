class Program
{
    static void Main()
    {
        int smallsize = 0;
        int mediumsize = 0;
        int largesize = 0;
        string choice = "";
        int totalbill = 0;

        Console.WriteLine("******CoffeeCafeDay Menu******");
        do {
            Console.WriteLine("Please choose coffee size:\n 1)small \n 2)medium \n 3)largest");
            Console.WriteLine("which coffee would you like to take?");
            string s = Console.ReadLine().ToUpper();
            switch (s)
            {
                case "SMALL":
                    Console.WriteLine("how many cups of small size?");
                    int sc = Convert.ToInt32(Console.ReadLine());
                    smallsize += sc;
                    break;
                case "MEDIUM":
                    Console.WriteLine("how many cups of medium size?");
                    int mc = Convert.ToInt32(Console.ReadLine());
                    mediumsize += mc;
                    break;
                case "LARGE":
                    Console.WriteLine("how many cups of small size?");
                    int lc = Convert.ToInt32(Console.ReadLine());
                    largesize += lc;
                    break;
                default:
                    Console.WriteLine("not available");
                    break;
            }
            Console.WriteLine("Would you like to continue?");
            choice = Console.ReadLine().ToUpper();

        } while (choice=="YES" || choice=="Y");

        if(smallsize>0 || mediumsize>0 || largesize>0)
        {
            Console.WriteLine("total bill printed");
        }
        if (smallsize > 0)
        {
            Console.WriteLine($"total mediumsize {smallsize}*20={smallsize * 20}");
            totalbill += smallsize * 20;
        }
        if (mediumsize > 0)
        {
            Console.WriteLine($"total smallsize {mediumsize}*20={mediumsize * 20}");
            totalbill += mediumsize * 20;
        }
        if (largesize > 0)
        {
            Console.WriteLine($"total smallsize {largesize}*20={largesize * 20}");
            totalbill += largesize * 20;
        }
        if (totalbill > 0)
        {
            Console.WriteLine($"totalbill:{totalbill}");
        }

        Console.WriteLine("******THANKS FOR VISIT!!!SEE YOU SOON******");



        Console.ReadLine();
    }
}


