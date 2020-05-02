using System;
using System.Collections.Generic;
using System.Text;

namespace studentGradeBook
{
    class Utility
    {
        public static int intTester(String prompt)
        {
            int result;
            bool intPass = int.TryParse(Console.ReadLine(), out result);
            String errorMessage = "You did not enter only numbers\n" + prompt;

            while (!intPass)
            {
                Console.WriteLine(errorMessage);
                intPass = int.TryParse(Console.ReadLine(), out result);
            }

            return result;
        }
    }
}
