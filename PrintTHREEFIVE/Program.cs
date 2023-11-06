
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter number");
        int num=int.Parse(Console.ReadLine());

        if(num%3==0 && num % 5 == 0)
        {
            Console.WriteLine("THREEFIVE");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine("THREE");
        }
        else if(num% 5 == 0)
        {
            Console.WriteLine("FIVE");
        }
        else
        {
            Console.WriteLine("NOT THREE & FIVE");
        }

        Console.ReadLine();
    }
}