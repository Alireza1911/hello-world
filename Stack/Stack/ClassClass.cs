using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
   public class ClassClass
    {

        //متد پوش
        public StackClass[] PushClass(StackClass input, ref int m, StackClass[] a)
        {
            m++;
            StackClass[] b = new StackClass[m];
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
        public StackClass[] Popclass(ref int m, StackClass[] a)
        {
            StackClass[] b;
            if (m < 1)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                m--;
                b = new StackClass[m];
                for (int i = 0; i < b.Length; i++)
                {
                    b[i] = a[i];
                }
                a = b;
            }
            return a;
        }
        public StackClass Peckclass(StackClass[] a, int m)
        {
            return a[m - 1];
        }
    }
}
