using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class CountSheep
    {
        public static void sheep()
        {
            int here = 0;
            int gone = 0;
            int unknown = 0;
            bool[] flock = new bool[6];
            for (int i = 0; i < flock.Length; i++)
            {
                Console.WriteLine("If the sheep is here write \"true\" if the sheep is gone write \"false\" and if you don't know where the sheep is write none");
                string a = Console.ReadLine();

                try
                {
                    bool b = Convert.ToBoolean(a);

                    if (b == true)
                    {
                        flock[i] = b;
                        here++;
                    }
                    else
                    {
                        flock[i] = b;
                        gone++;
                    }
                } catch(Exception e)
                {
                    unknown++;
                }
                
                
            }

            Console.WriteLine("There are " + here + " sheep here");
            Console.WriteLine("There are " + gone + " sheep gone");
            Console.WriteLine("There are " + unknown + " sheep unknown");
        }
    }
}
