using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class MultiplesOf3Or5
    {
        public static int Solution(int max)
        {
            int returnNumber = 0;

            for (int i = 0; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    returnNumber += i;
            }

            return returnNumber;
        }
    }
}