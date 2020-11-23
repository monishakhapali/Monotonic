using System;

namespace Monotonic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }
        public static bool IsMonotonic(int[] A)
        {
            bool inc = true;
            bool dec = true;
            for(int i=0;i<A.Length-1;++i)
            {
                if(A[i] < A[i+1])
                {
                    dec = false;
                }
                if (A[i] > A[i + 1])
                {
                    inc = false;
                }
            }
            return inc || dec;
        }
     }
}
