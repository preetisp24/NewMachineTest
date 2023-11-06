class Program
{
    static void Main()
    {
        Program.arr();
        Program.Print();
        Console.ReadLine();
    }

    public static void arr()
    {
        int[] num = { 1, 4, 5, 2 };
        int sum = 0;
        for (int i = 0; i < num.Length; i++)
        {
            sum += num[i];
        }
        Console.WriteLine($"sum of array elements :" + sum);


        
        Console.WriteLine();
    }

    public static void Print()
    {
       
    }
}
