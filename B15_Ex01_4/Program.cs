namespace B15_Ex01_4
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            bool v_IsNumber, v_IsString, v_isSizeTen;
            int i_number;

            Console.WriteLine("Please enter a string with 10 letters or a number with 10 digits:");
            string io_Input = Console.ReadLine();

            while( isValidInput(io_Input) ) {
                Console.WriteLine("Invalid input, please try again:");
                io_Input = Console.ReadLine();
            }
            isPolindrom(io_Input);
            v_IsNumber = int.TryParse(io_Input, out i_number);
            if (v_IsNumber)
            {
                sumDigits();
            }
            else
            {
                sumCamelCase();
            }

        }

        private static void sumCamelCase()
        {
            throw new NotImplementedException();
        }

        private static void sumDigits()
        {
            throw new NotImplementedException();
        }

        private static void isPolindrom(string io_Input)
        {
            throw new NotImplementedException();
        }

        private static bool isValidInput(string i_input)
        {
            int i_number;
            bool v_isSizeTen = i_input.Length == 10;
            bool v_IsNumber = int.TryParse(i_input, out i_number);
            bool v_IsString = IsOnlyLetters(i_input);

            return (!v_IsNumber || !v_IsString) && !v_isSizeTen;
        }

        private static bool IsOnlyLetters(string i_input)
        {
            bool v_IsOnlyLetters = true;

            char[] i_inputCharArray = i_input.ToCharArray();
            for (int i = 0; i < i_inputCharArray.Length; i++)
            {
                if (i_inputCharArray[i] < Char.GetNumericValue('a') || i_inputCharArray[i] > Char.GetNumericValue('Z'))
                {
                    v_IsOnlyLetters = false;
                }
            }
            return v_IsOnlyLetters;
        }
    }
}
