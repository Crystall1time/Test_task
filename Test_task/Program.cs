using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine(bsearch(arr, 12, 7)); //Example
            Console.ReadKey();
        }
        static int bsearch(int[] arr, int x, int n)
        {
            for (int i = 0; i < n; ++i)
            {
                if (arr[i] > x)
                    return i;
            }
            return -1;
        }
    }
}
