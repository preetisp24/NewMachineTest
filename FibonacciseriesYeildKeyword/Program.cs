class Program
{
    static void Main()
    {

        Console.ReadLine();
    }

    public static IEnumerable<int> Fib(int num)
    {
        if (num ==0)
        {
            yield return 0;
        }
        else if(num == 1)
        {
            yield return 1;
        }
        else
        {
           
        }

    }
}