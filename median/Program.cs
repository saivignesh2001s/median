using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace median
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[m];
            Console.WriteLine("Enter elements of array");
            for (int p = 0; p < a.Length; p++)
            {
                a[p] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter size of second array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] b = new int[n];
            for(int p = 0; p< n; p++)
            {
                b[p]=Convert.ToInt32(Console.ReadLine());   
            }
            int i = 0;
            int j = 0;
            int[] c = new int[m + n];
            int k = 0;
            while(i<m && j < n)
            {
                if (a[i] < b[j])
                {
                    c[k++] = a[i++];
                }
                else
                {
                    c[k++] = b[j++];
                }
            }
            for (; i < m; i++)
            {
                c[k++] = a[i];
            }
            for (; j < n; j++)
            {
                c[k++] = b[j];
            }
            double x;
            if ((m + n) % 2 == 0)
            {
                 x = c[(c.Length / 2)] + c[(c.Length / 2) - 1];
                x = x / 2;
                Console.WriteLine("The median is " + x);
            }
            else
            {
                x = c[(c.Length / 2) - 1];
                Console.WriteLine("The median is " + x);
            }
            double sum = 0;
         for(int p = 0; p < c.Length; p++)
            {
                sum += c[p];
            }
          sum /= c.Length;
            Console.WriteLine("Mean is " + sum);
           double mode = (3 * x) - (2*sum);
            Console.WriteLine("Mode is " + mode);

            Console.ReadLine();

        }
    }
}
