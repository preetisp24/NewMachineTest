
class Program
{
    static void Main()
    {
        int num = 6556;
        int rem;
        int result = 0;
        int temp = num;

        while(num!=0) { 
        rem = num % 10;  //remainder
        result =result*10+rem;   
        num = num / 10;  //qotient
        }
        num=temp;
        if(num==result)
        {
            Console.WriteLine("given number is Palindrome number");
        }
        else
        {
            Console.WriteLine("not palindrome number");
        }

        Console.ReadLine();
    }
}
