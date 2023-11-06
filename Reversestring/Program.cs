class Program
{
    public static void Main()
    {
        revstring r = new revstring();
        r.Rev();
        Console.ReadLine();
    }


        
}
public class revstring
{


    public void Rev()
    {
        string s = "Preeti";
        int sl = s.Length;
        int halflen = sl / 2;
        string firsthalf = s.Substring(0, halflen).ToUpper();
        string secondhalf = s.Substring(halflen).ToLower();
        string fullstring = firsthalf + secondhalf;

        char[] chararray = fullstring.ToCharArray();
        Array.Reverse(chararray);
        string reversestring = new string(chararray);
        Console.WriteLine($"Original string:{fullstring}");
        Console.WriteLine($"string after reverse:{reversestring}");


    }

}

