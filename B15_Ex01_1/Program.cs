namespace B15_Ex01_1
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int[] numbers = readNumbersFromUser(5, 3);
            int[] numbersBinary = printBinary(numbers);
            countAscendingsAndDescending(numbers);
            printAverage(numbers);
            printAverageDigitsInBinary(numbersBinary);
            Console.WriteLine("Please press 'Enter' to exit");
            Console.ReadLine();
        }

        private static void printAverageDigitsInBinary(int[] i_NumbersBinary)
        {
            int sumDigits = 0;
            foreach(int binaryNumber in i_NumbersBinary)
            {
                sumDigits += binaryNumber.ToString().Length;
            }

            float average = (float)sumDigits / i_NumbersBinary.Length;
            Console.WriteLine(string.Format("The avarege number of digits in the binary number is {0}", average));
        }

        private static void printAverage(int[] i_Numbers)
        {
            int sumAll = 0;
            foreach(int number in i_Numbers)
            {
                sumAll += number;
            }

            float average = (float)sumAll / i_Numbers.Length;
            Console.WriteLine(string.Format("The general avarege of the inserted numbers is {0}", average));
        }

        private static void countAscendingsAndDescending(int[] i_Numbers)
        {
            int sumAscendings = 0, sumDescendings = 0;
            foreach (int number in i_Numbers)
            {
                bool isAscending = true, isDescending = true;
                int tempNumber = number / 10, rightDigit = number % 10;
                for(int i = 0; i < 2; i++)
                {
                    if (rightDigit <= tempNumber % 10)
                    {
                        isAscending = false;
                    }

                    if (rightDigit >= tempNumber % 10)
                    {
                        isDescending = false;
                    }

                    rightDigit = tempNumber % 10;
                    tempNumber /= 10;
                }

                if(isAscending)
                {
                    sumAscendings++;
                }

                if (isDescending)
                {
                    sumDescendings++;
                }
            }

            Console.WriteLine(string.Format("The are {0} numbers which are ascending series and {1} which are descendings", sumAscendings, sumDescendings));
        }

        private static int[] printBinary(int[] i_Numbers)
        {
            Console.Write("The binary numbers are: ");
            int[] numbersBinary = new int[i_Numbers.Length];
            for(int i = 0; i < i_Numbers.Length; i++)
            {
                int result = 0, oneMovingBit = 1, tempNumber = i_Numbers[i];
                while (tempNumber != 0)
                 {
                    if(tempNumber % 2 == 1)
                    {
                        tempNumber -= 1;
                        result += oneMovingBit;
                    }

                    tempNumber /= 2;
                    oneMovingBit *= 10;
                }

                numbersBinary[i] = result;
                Console.Write(string.Format("{0} ", numbersBinary[i]));
            }

            Console.WriteLine();

            return numbersBinary;
        }

        private static int[] readNumbersFromUser(int i_NumOfNumbersToRead, int i_NumberOfDigits)
        {
            Console.WriteLine(string.Format("Please enter {0} numbers with {1} digits each", i_NumOfNumbersToRead, i_NumberOfDigits));
            string numberStr = string.Empty;
            int[] numbers = new int[i_NumOfNumbersToRead];
            for(int i = 0; i < i_NumOfNumbersToRead; i++)
            {
                numberStr = Console.ReadLine();
                bool isGoodInput = int.TryParse(numberStr, out numbers[i]) && numberStr.Length == 3;
                if (!isGoodInput)
                {
                    System.Console.WriteLine("The input you entered is invalid. Please try again.");
                    i--;
                }
            }

            return numbers;
        }
    }
}
