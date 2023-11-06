class Program
{
    static void Main()
    {
        string s = "eye";
        Console.WriteLine(s);
        string revstring = "";
        //char[] c= s.ToCharArray();
        for (int i = s.Length-1; i>-1; i--)
        {
            revstring += s[i];
        }
        Console.WriteLine("original string:" + s);
        Console.WriteLine("reversed string:" + revstring);

        if (s == revstring)
        {
            Console.WriteLine("Palindrome string");
        }
        else
        {
            Console.WriteLine("no PS");
        }

        //1.USING REVERSE METHOD
        //char[] c=s.Reverse().ToArray();
        //Console.WriteLine(c);

         //2.USING REVERSE METHOD
        //char[] c=s.ToCharArray();
        //Array.Reverse(c);
        //string revstring=new string(c);
        //Console.WriteLine(revstring); 




        Console.ReadLine();
    }
}
