namespace B15_Ex01_4
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            bool v_IsNumber;
            long io_InputInt;

            Console.WriteLine("Please enter a string with 10 letters or a number with 10 digits:");
            string io_Input = Console.ReadLine();

            while( isValidInput(io_Input) ) {
                Console.WriteLine("Invalid input, please try again:");
                io_Input = Console.ReadLine();
            }

            printIsPolindrom(io_Input);
            v_IsNumber = long.TryParse(io_Input, out io_InputInt);
            if (v_IsNumber)
            {
                sumDigits(io_InputInt);
            }
            else
            {
                sumCamelCase(io_Input);
            }

            System.Console.WriteLine("Please press 'Enter' to exit");
            System.Console.ReadLine();
        }

        private static void sumCamelCase(string i_Input)
        {
            int i_SumCamel = 0;
            char[] i_inputAsCharArray = i_Input.ToCharArray();
            for (int i = 0; i < i_inputAsCharArray.Length; i++ )
            {
                char i_CurLetter = i_inputAsCharArray[i];
                if (i_CurLetter >= 'A' && i_CurLetter <= 'Z')
                {
                    i_SumCamel++;
                }
            }
            Console.WriteLine("The number of camel case letter is: " + i_SumCamel);
        }

        private static void sumDigits(long i_number)
        {
            long i_Sum = 0;
            while(i_number > 0)
            {
                i_Sum += i_number % 10;
                i_number /= 10;
            }
            Console.WriteLine("The sum of all digits is: " + i_Sum);
        }

        private static void printIsPolindrom(string i_Input)
        {   
            bool v_IsPolindrom = true;
            char[] i_inputAsCharArray = i_Input.ToCharArray();
            for (int i = 0; i < i_inputAsCharArray.Length / 2; i++)
            {
                if (i_inputAsCharArray[i] != i_inputAsCharArray[i_inputAsCharArray.Length - i - 1])
                {
                    v_IsPolindrom = false;
                }
            }
            if (v_IsPolindrom)
            {
                Console.WriteLine("The input is a polindrom");
            }
            else
            {
                Console.WriteLine("The input is not a polindrom");
            }
        }

        private static void printIsPolindrom(int i_Input)
        {
            printIsPolindrom(i_Input.ToString());
        }

        private static bool isValidInput(string i_Input)
        {
            int i_number;
            bool v_isSizeTen = i_Input.Length == 10;
            bool v_IsNumber = int.TryParse(i_Input, out i_number);
            bool v_IsString = IsOnlyLetters(i_Input);

            return (!v_IsNumber || !v_IsString) && !v_isSizeTen;
        }

        private static bool IsOnlyLetters(string i_Input)
        {
            bool v_IsOnlyLetters = true;
            char[] i_inputAsCharArray = i_Input.ToCharArray();

            for (int i = 0; i < i_inputAsCharArray.Length; i++)
            {
                if (i_inputAsCharArray[i] < 'a' || i_inputAsCharArray[i] > 'Z')
                {
                    v_IsOnlyLetters = false;
                }
            }
            return v_IsOnlyLetters;
        }
    }
}
