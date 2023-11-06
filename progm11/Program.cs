class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int num=int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 1)
            {
              
              Console.Write($" {i} ");

            }

        }
        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($" {i} ");
            }

        }


        Console.ReadLine();
    }
}
