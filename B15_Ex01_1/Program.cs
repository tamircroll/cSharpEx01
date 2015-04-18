// -----------------------------------------------------------------------
// <copyright file="Program.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace B15_Ex01_1
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = readNumbersFromUser(5, 3);
            int[] numbersBinary = printBinary(numbers);
            countAscendingsAndDescending(numbers);
            printAverage(numbers);
            printAverageDigitsInBinary(numbersBinary);


            System.Console.ReadLine();
        }

        private static void printAverageDigitsInBinary(int[] numbersBinary)
        {
            int sumDigits = 0;
            foreach(int binaryNumber in numbersBinary)
            {
                sumDigits += binaryNumber.ToString().Length;
            }

            float average = (float) sumDigits / numbersBinary.Length;
            System.Console.WriteLine("The avarege number of digits in the binary number is " + average);
        }

        private static void printAverage(int[] numbers)
        {
             
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            float average = (float) sum / numbers.Length;
            System.Console.WriteLine("The general avarege of the inserted numbers is " + average);
        }

        private static void countAscendingsAndDescending(int[] numbers)
        {
            int sumAscendings = 0, sumDescendings = 0;
            foreach(int number in numbers)
            {
                bool isAscending = true, isDescending = true;
                int tempNumber = number / 10, rightDigit = number % 10;
                for (int i = 0 ; i < 2 ; i++)
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

                if (isAscending)
                {
                    sumAscendings++;
                }

                if (isDescending)
                {
                    sumDescendings++;
                }
            }

            System.Console.WriteLine("The are " + sumAscendings + " numbers which are ascending series and " + sumDescendings + " which are descendings");
        }

        private static int[] printBinary(int[] numbers)
        {
            System.Console.Write("The binary numbers are: ");
            int[] numbersBinary = new int[numbers.Length];
            for(int i = 0 ; i < numbers.Length ; i++)
            {
                int result = 0 , oneMovingBit = 1, tempNumber = numbers[i];
                while (tempNumber != 0)
                 {
                    if (tempNumber % 2 == 1)
                    {
                        tempNumber -= 1;
                        result += oneMovingBit;
                    }

                    tempNumber /= 2;
                    oneMovingBit *= 10;
                }

                numbersBinary[i] = result;
                System.Console.Write(numbersBinary[i] + " ");
            }

            System.Console.WriteLine();

            return numbersBinary;
        }

        private static int[] readNumbersFromUser(int numOfNumbersToRead, int numberOfDigits)
        {
            System.Console.WriteLine("Please enter " + numOfNumbersToRead + " numbers with " + numberOfDigits + " digits each");
            string numberStr = "";
            int[] numbers = new int[numOfNumbersToRead];
            for (int i = 0 ; i < numOfNumbersToRead ; i++)
            {
                numberStr = System.Console.ReadLine();
                bool goodInput = (int.TryParse(numberStr , out numbers[i])) && (numberStr.Length == 3);
                if (!goodInput)
                {
                    System.Console.WriteLine("The input you entered is invalid. Please try again.");
                    i--;
                }
            }

            return numbers;
        }
    }
}
