using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FindMaxAge
    {
        public static void maxAge(int[] ages)
        {
            int max = 0;
            int sameAge = 1;
            for(int i = 0; i < ages.Length; i++)
            {
                if(ages[i] > max)
                {
                    max = ages[i];
                } else if(ages[i] == max)
                {
                    sameAge++;
                }
            }

            if(sameAge > 1)
            {
                Console.WriteLine("There are " + sameAge + " students at the age of " + max);
            }
            else
            {
                Console.WriteLine("The oldest student is " + max + " years old.");
            }
        }
    }
}
