using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace baikiemtramangn
{
    internal class Program
    {
        private static object convert;

        static void Main(string[] args)
        {
            int n,i,dem=0,max=0;
            Console.WriteLine("nhap vao so luong phan tu: ");
          n = Convert.ToInt32(Console.ReadLine());
            int [] a = new int[n];
            for ( i = 0; i < n; i++)
            {
                Console.WriteLine("nhap phan tu thu:"+ (i+1));
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for ( i = 0;i < n; i++)
            {
                if (a[i]> max) {
                    max = a[i];
                    dem = i+1;
                }
            }
            Console.WriteLine("phan tu lon nhat la : " + max);
            Console.WriteLine("vi tri cua no trong mang la:" + dem);
            Console.ReadKey();
        }
    }
}
