using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main()
    {
        int[] num = { 23, 2, 5, 4, 9, 7 };
        int temp;

        for (int i = 0; i < num.Length; i++)
        {
            for (int j = i+1; j < num.Length; j++)
            {
                if (num[i] > num[j])
                {
                    temp = num[i]; //temp=23
                    num[i] = num[j]; //num[i]=2
                    num[j] = temp;  //num[j]=23
                }
            }
        }
        Console.WriteLine($"Highest number is: {num[num.Length-1]}");
        Console.WriteLine($"second highest num is: {num[num.Length-2]}");
        Console.WriteLine($"MininumNum is: {num[0]}");

        foreach (var item in num)
        {
            Console.Write($" {item} ");
        }

        Console.WriteLine();
        
       

        Console.ReadLine();
    }
}
