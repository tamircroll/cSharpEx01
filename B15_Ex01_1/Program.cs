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
            string[] numbersStr = new string[5];
            int[] numbers;

            numbers = readNumbersFromUser(5, 3);


        }


        private static int[] readNumbersFromUser(int numOfNumbersToRead, int numberOfDigits)
        {
            System.Console.WriteLine("Please enter " + numOfNumbersToRead + " numbers with " + numberOfDigits + " digits each");
            string numberStr = "";
            int[] numbers = new int[numOfNumbersToRead];
            for (int i = 0; i < numOfNumbersToRead ; i++)
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
