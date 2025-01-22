using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("user details module");
            Depositdll.Class1 obj= new Depositdll.Class1();
            obj.Deposit();
            Withdrawldl.Class1 obj2 = new Withdrawldl.Class1();
            obj2.withdrawl();
            Console.ReadLine(  );
        }
    }
}
