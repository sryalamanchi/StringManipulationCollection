using System;

namespace StringManipulationCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			//Console.WriteLine(superReducedString("aaabccd"));
			Console.WriteLine(FizzBuzz(15));


			//Console.WriteLine(Camelcase("dsddsTwoThree"));
			//Console.WriteLine(MinimumNumberPasswordValidation(2, "#HackerRank"));
			//Console.WriteLine(ReverseString("SRINI YALAMANCHI"));
			FizzBuzz(100);
            Console.ReadLine();
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
        #region StringReverseWithoutReverse
			
        static string ReverseString(string  inputString)
		{
			//string inputString = "SRINI YALAMANCHI";
			string reverseString = "";
			int length = inputString.Length - 1;
			while (length >= 0)
			{
				reverseString = reverseString + inputString[length];
				length--;
			}

			Console.WriteLine(reverseString);
            return reverseString;
           // Console.ReadLine();
		}
        static void ReverseArray()
		{
			int[] arr = new int[] { 1, 5, 8, 9, 0 };
			Console.WriteLine(arr);
			Array.Sort(arr);
			foreach (var value in arr)
			{
				Console.WriteLine(value + "Sort");
			}

			Array.Reverse(arr);
			foreach (var value in arr)
			{
				Console.WriteLine(value + "Reverse");
			}
			//var result = arr.OrderBy(c => c).ToArray().First();
			////foreach (var item in result)
			////{
			//	Console.WriteLine(result);
			//}
			//int temp;
			//for (int i=0; i<arr.Length-1; i++ )
			//{
			//	for (int j=i+1;j<arr.Length; j++)
			//	{
			//		if (arr[i] < arr[j])
			//		{
			//			temp = arr[i];
			//			arr[i] = arr[j];
			//			arr[j] = temp;
			//		}
			//	}
			//	foreach (var value in arr)
			//	{
			//		Console.WriteLine(value + "");
			//	}
			//Sorting Descending
			int[] intArray = new int[] { 2, 3, 4, 5, 9 };
			int temp = 0;
			for (int i = 0; i <= intArray.Length - 1; i++)
			{
				for (int j = i + 1; j < intArray.Length; j++)
				{
					if (intArray[i] < intArray[j])
					{
						temp = intArray[i];
						intArray[i] = intArray[j];
						intArray[j] = temp;
					}
				}
			}
			Console.WriteLine("Array Sort iscending Order:");
			foreach (var item in intArray)
			{
				Console.WriteLine(item);

			}
			Console.ReadLine();
			//Sorting Asceending.
		#region SortArrayWithoutSort
			
			int[] input = new int[] { 2, 3, 4, 5, 9 };
			int result = 0;
			for (int i = 0; i <= input.Length - 1; i++)
			{
				for (int j = i + 1; j < input.Length; j++)
				{
					if (input[i] > input[j])
					{
						result = input[i];
						input[i] = input[j];
						input[j] = result;
					}
				}
			}
			Console.WriteLine("Array Sort Ascending Order:");
			foreach (var i in input)
			{
				Console.WriteLine(i);

			}
		}
		#endregion
		#endregion
		#region Password Validation

		static int MinimumNumberPasswordValidation(int n, string password)
		{
            // Return the minimum number of characters to make the password strong
            // numbers = "0123456789";
            // lower_case = "abcdefghijklmnopqrstuvwxyz";
            // upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string special_characters = "!@#$%^&*()-+";
            int counter = 0;
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
		#region FizzBuzz
		public static string FizzBuzz(int n)
		{
			//n = 15;
			string s = "";
			for (int i = 0; i <= n; i++)
			{
				var mod5 = i % 5;
				var mod3 = i % 3;
				if (mod3 == 0 && mod5 == 0)
				{
					s= "FizzBuzz";
				}
				if (mod3 == 0)
				{
					//s = "Fizz";
					s= "Fizz";
				}
				if (mod5 == 0)
				{
					
					s= "Buzz";
				}
				//return s;
			}
			return s;

		}
	}
	#endregion
}

