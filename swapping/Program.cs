class Program
{
    static void Main()
    {
        int a = 30;
        int b = 20;
        int temp;
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine();
        temp = a; //temp=30 using 3rd variable
        a = b;   //a=20
        b = temp; //b=30

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine();
        //a=20 b=30
        a = a + b;  //a=20+30=50
        b = a - b; //b=50-30=20
        a = a - b;  //a=50-20=30
        Console.WriteLine(a);
        Console.WriteLine(b);
        

        Console.ReadLine();
    }
}