using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGen
{
   public class StackGenericeClass
    {
        //متد پوش
        public T[] Push<T>(T input, ref int m, T[] a)
        {
            m++;
            T[] b = new T[m];
            if (m == 1)
            {
                b[0] = input;
            }
            else
            {
                for (int i = 0; i < (b.Length) - 1; i++)
                {
                    b[i] = a[i];
                }
                b[m - 1] = input;
            }
            return b;
        }
        //متد پاپ
        public T[] Pop<T>(ref int m, T[] a)
        {
            T[] b;
            if (m < 1)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                m--;
                b = new T[m];
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = a[i];
                }
                a = b;
            }
            return a;
        }
        public T Peck<T>(T[] a, int m)
        {
            return a[m - 1];
        }
    }
}
