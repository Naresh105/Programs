using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MyApplication
{
    class Program
    {
        static void MyMethod(string fname)
        {
            Console.WriteLine(fname + " Refresh");
        }

        public void MyMethod()
        {
            Console.WriteLine("Refresh");

        }



        static void Method(string name)
        {
            Console.WriteLine(name + " Dot Net");
        }
        static void Method1()
        {
            Console.WriteLine("I am a Static Method");
        }
        static void Main(String[] args)
        {
            MyMethod("Liam");
            MyMethod("Jenny");
            MyMethod("Anja");

            Program obj = new Program();
            obj.MyMethod();
            Method("ravi");
            Program.Method1();
            MyApplication.Program1 obj1 = new MyApplication.Program1();
            obj1.Method2();

        }
    }
    namespace MyApplication
    {
        class Program1
        {
            public void Method2()
            {
                Console.WriteLine("I am out of class");
            }
        }
    }
}
