using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        int a = 300, b = 100, add, sub, Mul, div;
        Program.Calc(a, b, out add, out sub, out Mul, out div);
        Console.WriteLine(add);
        Console.WriteLine(sub);
        Console.WriteLine(Mul);
        Console.WriteLine(div);
        Console.ReadLine();
    }

    public static void Calc(int a, int b, out int add, out int sub, out int Mul, out int div)
    {
        a = 50;
        b = 20;
        add = a + b;
        sub = a - b;
        Mul = a * b;
        div = a / b;

    }
}


