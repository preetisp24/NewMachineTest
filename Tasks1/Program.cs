class Program
{

    static void Main()
    {
        #region Primenumber
        //Console.WriteLine("write any number");
        //int num=int.Parse(Console.ReadLine());
        //int count = 0;
        //for (int i = 1; i <= num; i++)
        //{
        //    if (num % i == 0)
        //    {
        //        count++;


        //    }
        //}
        //if (count == 2)
        //{
        //    Console.WriteLine(" prime number");
        //}
        //else
        //{
        //    Console.WriteLine("not prime number");
        //}
        #endregion
        #region PrimenumberTillLimit

        //Console.WriteLine("Enter limit");
        //int num=int.Parse(Console.ReadLine());

        //for (int i = 2; i <= num; i++)
        //{
        //    bool isPrime = true;
        //    for (int j = 2; j < i; j++)
        //    {
        //        if (i % j == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //    }
        //    if(isPrime)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        #endregion

        #region 3rd highest oneforloop & linq

        //int[] num = { 4, 2, 6, 9, 5, 7, 12, 1 };
        //int large = 0;
        //int medium = 0;
        //int small = 0;
        //for (int i = 0; i < num.Length; i++)
        //{
        //    if (large <= num[i] && medium <= large)
        //    {
        //        small = medium;
        //        medium = large;
        //        large = num[i];
        //    }
        //    else if (medium <= num[i] && small <= medium)
        //    {
        //        small = medium;
        //        medium = num[i];
        //    }
        //    else if (small <= num[i])
        //    {
        //        small = num[i];
        //    }
        //}
        //Console.WriteLine(large);
        //var items = num.OrderByDescending(x => x).Take(4).Min();
        //Console.WriteLine(items);
        #endregion

        #region sum7

        //int[] num = { 4, 3, 2, 5, 6, 1, 8, 5 };

        //for (int i = 0; i <num.Length; i++)
        //{
        //    for (int j = i+1; j < num.Length; j++)
        //    {
        //        if (num[i] + num[j] == 7)
        //        {
        //            Console.WriteLine($"{num[i]},{num[j]}");
        //        }
        //    }
        //}
        #endregion

        #region Anagrams
        //string s1 = "abdc";
        //string s2 = "dbca";

        //var T1 = s1.OrderBy(x => x);
        //var T2=s2.OrderBy(x => x);
        //bool c = T1.SequenceEqual(T2);
        //Console.WriteLine(c);
        #endregion

        #region reversestring
        // string s = "Preeti";

        //var s1= s.Reverse().ToArray();
        // Console.WriteLine(s1);
        #endregion

        #region palindrome number

        //Console.WriteLine("Enter number");
        //int num=int.Parse(Console.ReadLine());

        //int result = 0;
        //int rem = 0;
        //int temp = num;

        //while (num != 0)
        //{
        //    rem = num % 10;
        //    result = result * 10 + rem;
        //    num = num / 10;

        //}

        //num = temp;
        //if (num == result)
        //{
        //    Console.WriteLine("PN");
        //}
        //else
        //{
        //    Console.WriteLine("No PN");
        //}
        #endregion

        #region fibonacci series

        //int a = 0;
        //int b = 1;
        //int c;

        //for (int i = 0; i < 10; i++)
        //{
        //    c = a + b;
        //    Console.WriteLine(c);
        //    a = b;
        //    b = c;

        //}
        #endregion

        #region num occurences

        //int[] num = {5,5,6,5,10,6,2,2};

        //for (int i = 0; i <= num.Length-1; i++)
        //{
        //    int count = 1;
        //    for (int j = i+1; j <= num.Length-1; j++)
        //    {
        //        if (num[i] == num[j])
        //        {
        //            count++;
        //            break;

        //        }

        //    }
        //    Console.WriteLine($"{num[i]} : {count}");
        //}

        //Dictionary<int, int> dist = new Dictionary<int, int>();

        //foreach (var item in num)
        //{
        //    if (!dist.ContainsKey(item))
        //    {
        //       dist.Add(item, 1);
        //    }
        //    else
        //    {
        //        dist[item]++;
        //    }
        //}

        //foreach (var i in dist)
        //{
        //    Console.WriteLine($"{i.Key} : {i.Value}");
        //}
        #endregion

        #region Armstong number

        //Console.WriteLine("Enter num");
        //int num=int.Parse(Console.ReadLine());

        //int rem = 0;
        //int result = 0;
        //int cube = 0;
        //int temp = num;

        //while (num != 0)
        //{
        //    rem = num % 10;
        //    cube = rem * rem * rem;
        //    result=result+ cube;
        //    num = num / 10;
        //}

        //num = temp;
        //if (num == result)
        //{
        //    Console.WriteLine("AN");
        //}
        //else
        //{
        //    Console.WriteLine("No AN");
        //}
        #endregion
        Console.ReadLine();
    }
}