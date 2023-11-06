class Program
{
    static void Main()
    {
        Console.WriteLine("enter number");
        int num=int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(fib(i));
        }

        Console.ReadLine();
    }

    public static int fib(int x)
    {
        if (x == 0)
        {
            return 0;
        }
        else if (x == 1)
        {
            return 1;
        }
        else
        {
            return fib(x - 1) + fib(x - 2);
        }

        
    }
}