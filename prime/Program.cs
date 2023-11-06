class Program
{
    static void Main()
    {
        int count = 0;
        Console.WriteLine("Enter a number");
        int s=Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= s; i++)
        {
            if (s % i == 0)
            {
                count++;
            }
        }
        if(count==2)
        {
            Console.WriteLine("prime number");
        }
        else
        {
            Console.WriteLine("not prime number");
        }

        Console.ReadLine();
    }
}