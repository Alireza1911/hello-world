using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
   public class Stack_int
    {
        //متد پوش
        public int[] PushInt(int input, ref int m, int[]a)
        {
            m++;
            int[] b = new int[m];
            if (m==1)
            {
                b[0] = input;
            }
            else
            {
                for (int i = 0; i <( b.Length)-1; i++)
                {
                    b[i] = a[i];
                }
                b[m - 1] = input;
            }
            return b;
        }
        //متد پاپ
        public int[]PopInt(ref int m,int[]a)
        { 
            int[] b;
            if (m<1)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                m--;
                b = new int[m];
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = a[i];
                }
                a = b;
            }
            return a;
        }
        public int PeckInt(int[]a,int m)
        {
            return a[m - 1]; 
        }
    }
}
