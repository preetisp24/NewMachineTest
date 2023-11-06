
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a num");
        int num = int.Parse(Console.ReadLine());
        int rem;
        int cube;
        int result = 0;

        int temp = num;

        while (num != 0)
        {
            rem = num % 10;
            cube = rem * rem * rem;
            result += cube;
            num = num / 10;

        }

        num = temp;
        if (num == result)
        {
            Console.WriteLine("Amstrong number");
        }
        else
        {
            Console.WriteLine("Not an Armstrong number");
        }
       

        Console.ReadLine();
    }
}