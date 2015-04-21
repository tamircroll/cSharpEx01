namespace B15_Ex01_4
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            bool isNumber;
            long inputLong = -1;

            Console.WriteLine("Please enter a string with 10 letters or a number with 10 digits:");
            string inputStr = Console.ReadLine();

            while (!isValidInput(inputStr, out inputLong, out isNumber) )
            {
                Console.WriteLine("Invalid input, please try again:");
                inputStr = Console.ReadLine();
            }

            printIsPalindrome(inputStr);
            if (isNumber)
            {
                sumDigits(inputLong);
            }
            else
            {
                sumCamelCase(inputStr);
            }

            Console.WriteLine("Please press 'Enter' to exit");
            Console.ReadLine();
        }

        private static void sumCamelCase(string i_Input)
        {
            int sumCamel = 0;
            char[] inputAsCharArray = i_Input.ToCharArray();
            for (int i = 0; i < inputAsCharArray.Length; i++ )
            {
                char curLetter = inputAsCharArray[i];
                if (char.IsUpper(curLetter))
                {
                    sumCamel++;
                }
            }

            Console.WriteLine(string.Format("The number of camel case letter is: {0}", sumCamel));
        }

        private static void sumDigits(long i_Number)
        {
            long sum = 0;
            while(i_Number > 0)
            {
                sum += i_Number % 10;
                i_Number /= 10;
            }

            Console.WriteLine(string.Format("The sum of all digits is: {0}", sum));
        }

        private static void printIsPalindrome(string i_Input)
        {   
            bool isPalindrome = true;
            char[] inputAsCharArray = i_Input.ToCharArray();
            for (int i = 0; i < inputAsCharArray.Length / 2; i++)
            {
                if (inputAsCharArray[i] != inputAsCharArray[inputAsCharArray.Length - i - 1])
                {
                    isPalindrome = false;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine("The input is a palindrome");
            }
            else
            {
                Console.WriteLine("The input is not a palindrome");
            }
        }

        private static void printIsPalindrome(int i_InputInt)
        {
            printIsPalindrome(i_InputInt.ToString());
        }

        private static bool isValidInput(string i_Input, out long io_Number, out bool io_IsNumber)
        {
            bool isSizeTen = i_Input.Length == 10;
            io_IsNumber = long.TryParse(i_Input, out io_Number);
            if (io_IsNumber && io_Number <= 0)
            {
                io_IsNumber = false;
            }

            bool isString = IsOnlyLetters(i_Input);

            return (io_IsNumber || isString) && isSizeTen;
        }

        private static bool IsOnlyLetters(string i_Input)
        {
            char[] inputAsCharArray = i_Input.ToCharArray();

            for (int i = 0; i < inputAsCharArray.Length; i++)
            {
                if (!char.IsLetter(inputAsCharArray[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
