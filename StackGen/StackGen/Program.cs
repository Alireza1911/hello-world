using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackGen
{
    class Program
    {
        static void Main(string[] args)
        {//معرفی ثوابت
            int andis_ofint = 0, andis_ofstring = 0, andis_ofclass = 0;
            //معرفی ارایه جهت استک اینت
            int[] arrayint = null;
            //معرفی ارایه جهت استک استرینگ
            string[] arraystring = null;
            //ساخت کلاس و ارایه جهت استک کلاس
            StackClass c = new StackClass();
            StackClass d = new StackClass();
            StackClass[] arrayclass = null;
            //ساخت کلاس جهت رفتارهای مرتبط با استک 
            StackGenericeClass a = new StackGenericeClass();
            //int
            arrayint = a.Push(4, ref andis_ofint, arrayint);
            arrayint = a.Push(7, ref andis_ofint, arrayint);
            arrayint = a.Pop(ref andis_ofint, arrayint);
            int peckint = a.Peck(arrayint, andis_ofint);
            //string
            arraystring = a.Push("ali", ref andis_ofstring, arraystring);
            arraystring = a.Push("reza", ref andis_ofstring, arraystring);
            arraystring = a.Pop(ref andis_ofstring, arraystring);
            string peckstring = a.Peck(arraystring, andis_ofint);
            //class
            arrayclass = a.Push(c, ref andis_ofclass, arrayclass);
            arrayclass = a.Push(d, ref andis_ofclass, arrayclass);
            arrayclass = a.Pop(ref andis_ofclass,arrayclass);
            StackClass peckclass = a.Peck(arrayclass, andis_ofclass);

        }
    }
}
