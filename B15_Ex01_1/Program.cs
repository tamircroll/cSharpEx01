namespace B15_Ex01_1
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int[] i_Numbers = readNumbersFromUser(5, 3);
            int[] i_NumbersBinary = printBinary(i_Numbers);
            countAscendingsAndDescending(i_Numbers);
            printAverage(i_Numbers);
            printAverageDigitsInBinary(i_NumbersBinary);
            Console.WriteLine("Please press 'Enter' to exit");
            Console.ReadLine();
        }

        private static void printAverageDigitsInBinary(int[] i_NumbersBinary)
        {
            int i_SumDigits = 0;
            foreach(int i_BinaryNumber in i_NumbersBinary)
            {
                i_SumDigits += i_BinaryNumber.ToString().Length;
            }

            float i_Average = (float)i_SumDigits / i_NumbersBinary.Length;
            Console.WriteLine(string.Format("The avarege number of digits in the binary number is {0}" , i_Average));
        }

        private static void printAverage(int[] i_Numbers)
        {
            int i_Sum = 0;
            foreach(int i_Number in i_Numbers)
            {
                i_Sum += i_Number;
            }

            float i_Average = (float)i_Sum / i_Numbers.Length;
            Console.WriteLine(string.Format("The general avarege of the inserted numbers is {0}" , i_Average));
        }

        private static void countAscendingsAndDescending(int[] i_Numbers)
        {
            int i_SumAscendings = 0, i_SumDescendings = 0;
            foreach (int i_Number in i_Numbers)
            {
                bool v_IsAscending = true, v_IsDescending = true;
                int i_TempNumber = i_Number / 10, i_RightDigit = i_Number % 10;
                for(int i = 0; i < 2; i++)
                {
                    if (i_RightDigit <= i_TempNumber % 10)
                    {
                        v_IsAscending = false;
                    }

                    if (i_RightDigit >= i_TempNumber % 10)
                    {
                        v_IsDescending = false;
                    }

                    i_RightDigit = i_TempNumber % 10;
                    i_TempNumber /= 10;
                }

                if(v_IsAscending)
                {
                    i_SumAscendings++;
                }

                if (v_IsDescending)
                {
                    i_SumDescendings++;
                }
            }

            Console.WriteLine(string.Format("The are {0} numbers which are ascending series and {1} which are descendings", i_SumAscendings, i_SumDescendings));
        }

        private static int[] printBinary(int[] i_Numbers)
        {
            Console.Write("The binary numbers are: ");
            int[] o_NumbersBinary = new int[i_Numbers.Length];
            for(int i = 0; i < i_Numbers.Length; i++)
            {
                int i_Result = 0, i_OneMovingBit = 1, i_TempNumber = i_Numbers[i];
                while (i_TempNumber != 0)
                 {
                    if(i_TempNumber % 2 == 1)
                    {
                        i_TempNumber -= 1;
                        i_Result += i_OneMovingBit;
                    }

                    i_TempNumber /= 2;
                    i_OneMovingBit *= 10;
                }

                o_NumbersBinary[i] = i_Result;
                Console.Write(string.Format("{0} ", o_NumbersBinary[i]));
            }

            Console.WriteLine();

            return o_NumbersBinary;
        }

        private static int[] readNumbersFromUser(int i_NumOfNumbersToRead, int i_NumberOfDigits)
        {
            Console.WriteLine(string.Format("Please enter {0} numbers with {1} digits each", i_NumOfNumbersToRead, i_NumberOfDigits));
            string i_NumberStr = string.Empty;
            int[] o_Numbers = new int[i_NumOfNumbersToRead];
            for(int i = 0; i < i_NumOfNumbersToRead; i++)
            {
                i_NumberStr = Console.ReadLine();
                bool v_goodInput = int.TryParse(i_NumberStr, out o_Numbers[i]) && i_NumberStr.Length == 3;
                if (!v_goodInput)
                {
                    System.Console.WriteLine("The input you entered is invalid. Please try again.");

                    i--;
                }
            }

            return o_Numbers;
        }
    }
}
