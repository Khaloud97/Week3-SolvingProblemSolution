namespace Week3_SolvingProblem
{
    class Program
    {
        static bool IsPalindRome(int x)
        {
            string s = x.ToString();//Changed from int to string
            string revsS = "";
            for(int i=s.Length-1; i>=0; i--)
            {
                revsS += s[i];
            }
            if(s== revsS)
            {
                return true;
            }
            return false;
        }

        static bool IsPalindRomeOtherWay(int x)
        {
            string s = x.ToString();//Changed from int to string
            int start = 0,end= s.Length - 1;

            while (start <= end)
            {
                if (s[start] != s[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            
            return true;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(IsPalindRome(121));
            Console.WriteLine(IsPalindRome(-121));
            Console.WriteLine(IsPalindRome(10));
            Console.WriteLine(IsPalindRome(-10)); 

            Console.WriteLine("----------------------------------");
            Console.WriteLine(IsPalindRomeOtherWay(-10));
            Console.WriteLine(IsPalindRomeOtherWay(121));


        }
    }
}