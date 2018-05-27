using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
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
            //ساخت کلاس جهت رفتارهای مرتبط با استک اینت
            Stack_int stackint = new Stack_int();
            arrayint = stackint.PushInt(4, ref andis_ofint, arrayint);
            arrayint = stackint.PushInt(7, ref andis_ofint, arrayint);
            arrayint = stackint.PopInt(ref andis_ofint, arrayint);
            int peckint = stackint.PeckInt(arrayint, andis_ofint);
            //ساخت کلاس جهت رفتارهای مرتبط با استک استرینگ
            StringClass stackstring = new StringClass();
            arraystring = stackstring.Pushstring("ali", ref andis_ofstring, arraystring);
            arraystring = stackstring.Pushstring("reza", ref andis_ofstring, arraystring);
            arraystring = stackstring.Popstring(ref andis_ofstring, arraystring);
            string peckstring = stackstring.Peckstring(arraystring, andis_ofstring);
            //ساخت کلاس جهت رفتارهای مرتبط با استک کلاس
            ClassClass stackclass = new ClassClass();
            arrayclass = stackclass.PushClass(c, ref andis_ofclass, arrayclass);
            arrayclass = stackclass.PushClass(d, ref andis_ofclass, arrayclass);
            arrayclass = stackclass.Popclass(ref andis_ofclass, arrayclass);
            StackClass f = stackclass.Peckclass(arrayclass, andis_ofclass);
        }
    }
}
