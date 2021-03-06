﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{

    /*
    EXPLANATION

    A Narcissistic Number is a positive number which is the sum of its own digits, 
    each raised to the power of the number of digits in a given base. In this Kata, 
    we will restrict ourselves to decimal (base 10).
    */

    /*
    TASK

    Your code must return true or false depending upon whether the given number is a Narcissistic number in base 10.
    Error checking for text strings or other invalid inputs is not required, 
    only valid positive non-zero integers will be passed into the function.
    */

    public static class NarcissisticNumber
    {
        public static bool Solution(int value)
        {
            //Power that is applied to every number
            int pow = value.ToString().Length;

            double narCheck = 0;

            foreach (var val in value.ToString())
            {
                int valAsInt = int.Parse(val.ToString());
                narCheck += Math.Pow(valAsInt,pow);
            }

            return narCheck == value;
        }
    }
}
