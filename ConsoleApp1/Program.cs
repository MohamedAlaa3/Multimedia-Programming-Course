using System;

namespace ConsoleApp1
{
    // you can also use other imports, for example:
    // using System.Collections.Generic;

    // you can write to stdout for debugging purposes, e.g.
    // Console.WriteLine("this is a debug message");

    class Solution
    {
        public int solution2(int[] A, int Y)
        {
            // write your code in C#
            int max = -99999999;
            int ct = 1;
            int k;
            int i;
            k = 1;
            for (i = 0; i < A.Length-1; i++)
            {

                if (A[k] - A[i] == Y)
                {
                    for (;  k< A.Length; k++)
                    {
                        if (A[k] - A[i] == Y)
                        {
                            ct++;


                        }
                        ct++;

                    }
                }
                else
                {
                    for (k = i + 2; k < A.Length - 1; k++)
                    {
                        if (A[k] - A[i] == Y)
                        {
                            ct++;

                            i = k;

                        }
                    }
                }


            }
            return ct;
        }
        int[] A = { 1, 2, 3 };
        int Y = 1;
        int m = solution2(A, Y);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
