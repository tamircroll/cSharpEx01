namespace B15_Ex01_5
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main() 
        {
            char[] inputChar = getInputNumber();
            countDigitsBiggerThenFirst(inputChar);
            countDigitsSmallerThenFirst(inputChar);
            printBiggestDigit(inputChar);
            printSmallestDigit(inputChar);

            Console.WriteLine("Please press 'Enter' to exit");
            Console.ReadLine();
        }

        private static void printBiggestDigit(char[] i_InputChar)
        {
            char biggest = i_InputChar[0];

            for (int i = 1; i < i_InputChar.Length; i++)
            {
                if (biggest < i_InputChar[i])
                {
                    biggest = i_InputChar[i];
                }
            }

            Console.WriteLine(string.Format("The biggest digit is: {0}", biggest));
        }

        private static void printSmallestDigit(char[] i_InputChar)
        {
            char smallest = i_InputChar[0];

            for (int i = 1; i < i_InputChar.Length; i++)
            {
                if (smallest > i_InputChar[i])
                {
                    smallest = i_InputChar[i];
                }
            }

            Console.WriteLine(string.Format("The smallest digit is: {0}", smallest));
        }

        private static void countDigitsSmallerThenFirst(char[] i_InputChar)
        {
            int sumSmaller = 0;

            for (int i = 1; i < i_InputChar.Length; i++)
            {
                if (i_InputChar[0] > i_InputChar[i])
                {
                    sumSmaller++;
                }
            }

            Console.WriteLine(string.Format("There are {0} digits that smaller from the first digit", sumSmaller));
        }

        private static void countDigitsBiggerThenFirst(char[] i_InputChar)
        {
            int sumBigger = 0;

            for (int i = 1; i < i_InputChar.Length; i++ )
            {
                if (i_InputChar[0] < i_InputChar[i])
                {
                    sumBigger++;
                }
            }

            Console.WriteLine(string.Format("There are {0} digits that bigger from the first digit", sumBigger));
        }

        private static char[] getInputNumber()
        {
            bool goodInput = false;
            int inputInt = 0;
            string inputStr = string.Empty;

            Console.WriteLine("Please enter 8 digit long number:");
            while (!goodInput)
            {
                inputStr = Console.ReadLine();
                goodInput = int.TryParse(inputStr, out inputInt) && inputStr.Length == 8;
                if (!goodInput)
                {
                    Console.WriteLine("Invalid input, Try again:");
                }
            }

            return inputStr.ToCharArray();
        }
    }
}
