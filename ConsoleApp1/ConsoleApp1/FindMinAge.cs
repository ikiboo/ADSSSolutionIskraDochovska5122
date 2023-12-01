using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class FindMinAge
    {
        public static void minAge(int[] ages)
        {
            int min = ages[0];
            int sameAge = 1;
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < min)
                {
                    min = ages[i];
                }
                else if (ages[i] == min)
                {
                    sameAge++;
                }
            }

            if (sameAge > 1)
            {
                Console.WriteLine("There are " + sameAge + " students at the age of " + min + " who are the youngest in the group.");
            }
            else
            {
                Console.WriteLine("The youngest student is " + min + " years old.");
            }
        }
    }
}
