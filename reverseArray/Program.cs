class Program
{
    static void Main()
    {
        int[] num = new int[] { 11, 12, 32, 15, 6, 21 };
        int numlength = num.Length - 1;

        for (int i = numlength; i >-1; i--)
        {
            Console.Write($" {num[i]} ");
        }
        Console.ReadLine();
    }
}