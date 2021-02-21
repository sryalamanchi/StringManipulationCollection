using System;

namespace StringManipulationCollection
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine(superReducedString("aaabccd"));
          
            Console.WriteLine(Camelcase("dsddsTwoThree"));
            Console.WriteLine(MinimumNumberPasswordValidation(2, "#HackerRank"));
        }
        #region SuperReducingString
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
        #endregion
        #region CamelCase
        static int Camelcase(string s)
        {

            int counter = 1;
            if (s.Trim().Length > 0)
            {
                for (int i = 1; i < s.Length - 1; i++)
                {
                    if (Char.IsUpper(s[i]))
                    {
                        counter++;
                    }
                }

            }
            return counter;
        }
		#endregion

		#region Password Validation

        static int MinimumNumberPasswordValidation(int n, string password)
		{
            // Return the minimum number of characters to make the password strong
            // numbers = "0123456789";
            // lower_case = "abcdefghijklmnopqrstuvwxyz";
            // upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";
            int counter = 0, minCount = 0;
            bool uppercase = false, lowercase = false, number = false, special = false;

            if (n > 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (char.IsUpper(password[i])) uppercase = true;
                    if (char.IsLower(password[i])) lowercase = true;
                    if (char.IsNumber(password[i])) number = true;
                    // if(char.IsSymbol(password[i])) special = true;
                    // if(password[i] ==0 || password[i] <= 9) number = true;
                    foreach (char element in special_characters)
                    {
                        if (element == password[i]) special = true;
                    }
                    // special = special_characters.Contains(password[i]);
                }
                // Console.WriteLine("{1} {2} {3} {4}", uppercase, lowercase, number, special);
                if (!uppercase) counter++;
                if (!lowercase) counter++;
                if (!number) counter++;
                if (!special) counter++;
            }
            // if(n < 6){
            //     minCount = 6 - n;
            // } 
            // if(minCount + counter != 6 && n < 6){

            // }

            return Math.Max(counter, 6 - n);
        }
		#endregion

	}
}
