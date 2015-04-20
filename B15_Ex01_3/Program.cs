namespace B15_Ex01_3
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using B15_Ex01_2;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter height of sand clock: ");
            int clockHeightInt;
            string clockHeightStr = Console.ReadLine();
            bool goodInput = int.TryParse(clockHeightStr, out clockHeightInt) && clockHeightInt >= 0;
            while (!goodInput)
            {
                Console.WriteLine("Invalid input, try Again: ");
                clockHeightStr = Console.ReadLine();
                goodInput = int.TryParse(clockHeightStr, out clockHeightInt) && clockHeightInt >= 0;
            }

            string sandClock = B15_Ex01_2.Program.PrintSendClock(clockHeightInt);
            Console.WriteLine(sandClock);
            Console.WriteLine("Please press 'Enter' to exit");
            Console.ReadLine();
        }
    }
}
