using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] students = new int[8];
            for(int i = 0; i < 8; i++)
            {
                int j = i+1;
                Console.Write("Enter the value for student number ");
                Console.WriteLine(j);
                string a = Console.ReadLine();
                try
                {
                    students[i] = Convert.ToInt32(a);
                } catch(Exception e)
                    { 
                    Console.WriteLine(e);
                }
                
            }
            FindMaxAge.maxAge(students);
            FindMinAge.minAge(students);
        }
    }
}
