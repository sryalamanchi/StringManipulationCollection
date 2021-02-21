using System;

namespace StringManipulationCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			string s = superReducedString("aaabccd");
            Console.WriteLine(s);

        }
        static string superReducedString(string s)
        {
            //inputstring aaabcddd
            
            if (s.Trim().Length > 0)
            {
                for (int i = 0; i < s.Length - 1; i++)
                {
                    if (s[i] == s[i + 1])
                    {
                        s = s.Remove(i, 2);
                        i = -1;
                    }

                }
            }
            if (s.Length == 0)
            {
                return "Empty String";
            }
            return s;

        }

    }
}
