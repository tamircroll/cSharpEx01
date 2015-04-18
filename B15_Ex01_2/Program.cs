namespace B15_Ex01_2
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string sandClock = PrintSendClock(5);
            System.Console.WriteLine(sandClock);
            System.Console.WriteLine("Please press 'Enter' to exit");
            System.Console.ReadLine();
        }

        public static string PrintSendClock(int i_clockHeight)
        {
            if (i_clockHeight % 2 == 1)
            {
                i_clockHeight--;
            }

            StringBuilder result = new StringBuilder(string.Empty);
            int i_ToIgnore, i_ToDraw;
            for (int i = -i_clockHeight; i <= i_clockHeight; i = i + 2)
            {
                i_ToIgnore = (i_clockHeight - Math.Abs(i)) / 2;
                i_ToDraw = Math.Abs(i) + 1;
                for (int j = 0; j <= i_ToIgnore; j++)
                {
                    result.Append(" ");
                }

                for (int j = 0; j < i_ToDraw; j++)
                {
                    result.Append("*");
                }

                result.Append("\n");
            }

            return result.ToString();
        }
    }
}
