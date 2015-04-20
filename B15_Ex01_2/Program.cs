namespace B15_Ex01_2
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string sandClock = PrintSendClock(5);
            Console.WriteLine(sandClock);
            Console.WriteLine("Please press 'Enter' to exit");
            Console.ReadLine();
        }

        public static string PrintSendClock(int i_clockHeight)
        {
            if (i_clockHeight % 2 == 1)
            {
                i_clockHeight--;
            }

            StringBuilder result = new StringBuilder(string.Empty);
            int toIgnore, toDraw;

            for (int i = -i_clockHeight; i <= i_clockHeight; i = i + 2)
            {
                toIgnore = (i_clockHeight - Math.Abs(i)) / 2;
                toDraw = Math.Abs(i) + 1;
                for (int j = 0; j <= toIgnore; j++)
                {
                    result.Append(" ");
                }

                for (int j = 0; j < toDraw; j++)
                {
                    result.Append("*");
                }

                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
