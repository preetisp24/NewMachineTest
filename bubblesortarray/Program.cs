class Program
{
    static void Main()
    {
        int[] num = { 4, 3, 9, 6, 10, 2 };
        int temp;

        for (int i = 0; i < num.Length; i++)
        {
            for (int j = i+1; j < num.Length; j++)
            {
                if (num[i] > num[j])
                {
                   temp = num[i];  //temp=num[i]=4
                    num[i] = num[j]; //num[i]=3
                    num[j]= temp;  //num[j]=4


                }
            }
        }
        foreach (int item in num)
        {
            Console.Write($" {item} ");
        }
        Console.ReadLine();
    }
}
