
class Program
{
    static void Main()
    {
        int fs=10;
        int a= 0;
        int b= 1;
        int c=0;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 0; i < fs; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
      
        }

        Console.ReadLine();
    }
}
