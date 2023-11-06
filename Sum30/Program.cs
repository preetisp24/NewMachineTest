
class Program
{
    static void Main()
    {
        int[] num = { 10, 20, 18, 12, 4, 7, 8 };

        for (int i = 0; i < num.Length; i++)
        {
            for (int j = i+1; j < num.Length; j++)
            {
                if (num[i] + num[j] == 30)
                {
                    Console.WriteLine($"{num[i]} + {num[j]} = 30 ");
                }
            }

        }
        Console.ReadLine();
    }
}