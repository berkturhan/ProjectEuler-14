using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler14
{
    class Program
    {
        static void Main(string[] args)
        {

            long count = 1;           
            //List<int> list = new List<int>();
            long[] arr = new long[1000000];
            /*
            for (int i = 1; i < 1000000; i++)
            {
                count = Recursive(i, ref count,i);
                list.Add(count);
                count = 0;
            }
            */

            for (long i = 1; i < 1000001; i++)
            {
                long n = i;
                while (n > 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    count++;
                }
                arr[i - 1] = count;              
                count = 1;
            }
            // Finding max
            long m = arr.Max();
            // Positioning max
            long p = Array.IndexOf(arr, m)+1;
            Console.WriteLine(p);
            Console.ReadLine();
        }
        static int Recursive(int value, ref int count, int i)
        {
            int ind = i;
            count++;
            if (value <= 1)
            {
                return count;
            }
            if(value % 2 == 0)
                return Recursive(value/2, ref count,ind);
            else
                return Recursive(3*value + 1, ref count,ind);
        }
    }
}
