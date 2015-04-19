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

        private static void printBiggestDigit(char[] i_inputChar)
        {
            char biggest = i_inputChar[0];

            for (int i = 1; i < i_inputChar.Length; i++)
            {
                if (biggest < i_inputChar[i])
                {
                    biggest = i_inputChar[i];
                }
            }

            Console.WriteLine(string.Format("The biggest digit is: {0}", Char.ToString(biggest)));
        }

        private static void printSmallestDigit(char[] i_inputChar)
        {
            char smallest = i_inputChar[0];

            for (int i = 1; i > i_inputChar.Length; i++)
            {
                if (smallest < i_inputChar[i])
                {
                    smallest = i_inputChar[i];
                }
            }

            Console.WriteLine(string.Format("The smallest digit is: {0}", smallest));
        }

        private static void countDigitsSmallerThenFirst(char[] i_inputChar)
        {
            char sumSmaller = '9';

            for (int i = 1; i < i_inputChar.Length; i++)
            {
                if (i_inputChar[0] > i_inputChar[i])
                {
                    sumSmaller++;
                }
            }

            Console.WriteLine(string.Format(@"There are {0} digits that smaller from the first digit" , sumSmaller));
        }


        private static void countDigitsBiggerThenFirst(char[] i_inputChar)
        {
            char sumBigger = '0';

            for (int i = 1; i < i_inputChar.Length; i++ )
            {
                if (i_inputChar[0] < i_inputChar[i])
                {
                    sumBigger++;
                }
            }

            Console.WriteLine(string.Format("There are {0} digits that bigger from the first digit", sumBigger));
        }

        static private char[] getInputNumber()
        {
            bool goodInput = false;
            int inputInt = 0;
            string inputStr = "";

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
