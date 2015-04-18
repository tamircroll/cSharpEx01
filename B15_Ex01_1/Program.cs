namespace B15_Ex01_1
{
    public class Program
    {
        public static void Main()
        {
            int[] i_Numbers = readNumbersFromUser(5, 3);
            int[] i_NumbersBinary = printBinary(i_Numbers);
            countAscendingsAndDescending(i_Numbers);
            printAverage(i_Numbers);
            printAverageDigitsInBinary(i_NumbersBinary);
            System.Console.WriteLine("Please press 'Enter' to exit");
            System.Console.ReadLine();
        }

        private static void printAverageDigitsInBinary(int[] i_NumbersBinary)
        {
            int i_SumDigits = 0;
            foreach(int i_BinaryNumber in i_NumbersBinary)
            {
                i_SumDigits += i_BinaryNumber.ToString().Length;
            }

            float i_Average = (float)i_SumDigits / i_NumbersBinary.Length;
            System.Console.WriteLine("The avarege number of digits in the binary number is " + i_Average);
        }

        private static void printAverage(int[] i_Numbers)
        {
            int i_Sum = 0;
            foreach(int i_Number in i_Numbers)
            {
                i_Sum += i_Number;
            }

            float i_Average = (float)i_Sum / i_Numbers.Length;
            System.Console.WriteLine("The general avarege of the inserted numbers is " + i_Average);
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

            System.Console.WriteLine("The are " + i_SumAscendings + " numbers which are ascending series and " + i_SumDescendings + " which are descendings");
        }

        private static int[] printBinary(int[] i_Numbers)
        {
            System.Console.Write("The binary numbers are: ");
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
                System.Console.Write(o_NumbersBinary[i] + " ");
            }

            System.Console.WriteLine();

            return o_NumbersBinary;
        }

        private static int[] readNumbersFromUser(int i_NumOfNumbersToRead, int i_NumberOfDigits)
        {
            System.Console.WriteLine("Please enter " + i_NumOfNumbersToRead + " numbers with " + i_NumberOfDigits + " digits each");
            string i_NumberStr = string.Empty;
            int[] o_Numbers = new int[i_NumOfNumbersToRead];
            for(int i = 0; i < i_NumOfNumbersToRead; i++)
            {
                i_NumberStr = System.Console.ReadLine();
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
