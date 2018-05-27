using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
   public class StringClass
    {
        //متد پوش
        public string[] Pushstring(string input, ref int m, string[] a)
        {
            m++;
            string[] b = new string[m];
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
        public string[] Popstring(ref int m, string[] a)
        {
            string[] b;
            if (m < 1)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                m--;
                b = new string[m];
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = a[i];
                }
                a = b;
            }
            return a;
        }
        public string Peckstring(string[] a, int m)
        {
            return a[m - 1];
        }
    }
}
