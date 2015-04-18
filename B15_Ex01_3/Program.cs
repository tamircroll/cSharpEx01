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
            int i_clockHeightInt;
            string i_clockHeightStr = Console.ReadLine();
            bool v_goodInput = int.TryParse(i_clockHeightStr, out i_clockHeightInt);
            while (!v_goodInput)
            {
                Console.WriteLine("Invalid input, try Again: ");
                i_clockHeightStr = Console.ReadLine();
                v_goodInput = int.TryParse(i_clockHeightStr, out i_clockHeightInt);
            }

            string i_sandClock = B15_Ex01_2.Program.PrintSendClock(i_clockHeightInt);
            Console.WriteLine(i_sandClock);
            Console.WriteLine("Please press 'Enter' to exit");
            Console.ReadLine();
        }
    }
}
