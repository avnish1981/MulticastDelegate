using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate int Delegate(out int a);
    class Program
    {
        static void Main(string[] args)
        {

            //Delegate obj = new Delegate(DelegateMethodInvoked);
            //obj();
            //Multicast Delegate Example.
            /*  Delegate obj1, obj2, obj3, obj4;
              obj1 = new Delegate(DelegateMethodInvoked);
              obj2 = new Delegate(DelegateMethodInvokedTwo);
              obj3 = new Delegate(DelegateMethodInvokedThree);
              //obj1();
              //obj2();
              //obj3();
              obj4 = obj1 + obj2 + obj3 - obj3;
              obj4(); */

            /*    Delegate obj = new Delegate(DelegateMethodInvoked);
                obj += DelegateMethodInvokedTwo;
                obj += DelegateMethodInvokedThree;
                obj -= DelegateMethodInvokedThree;
                obj(); */
            //Delegate obj = new Delegate(DelegateMethodInvoked);
            //obj += DelegateMethodInvokedTwo;
            //int delegatereturnedValue = obj();
            //Console.WriteLine("Value is {0}", delegatereturnedValue);
            Delegate obj = new Delegate(DelegateMethodInvoked);
            obj += DelegateMethodInvokedTwo;
            int a = 3;
            int retrenValue = obj(out a);
            Console.WriteLine("Returned Value is {0}", retrenValue);

        }

        /* public static  void DelegateMethodInvoked()
         {
             Console.WriteLine("DelegateMethodInvoked");
         }
         public static void DelegateMethodInvokedTwo()
         {
             Console.WriteLine("DelegateMethodInvokedTwo");
         }
         public static void DelegateMethodInvokedThree()
         {
             Console.WriteLine("DelegateMethodInvokedThree");
         } */

        public static int DelegateMethodInvoked(out int a)
        {
            a = 1;
            return a;
            
            //return 1;
        }
        public static int DelegateMethodInvokedTwo(out int b)
        {
            b = 2;
            return b;
           // return 2;
        }
    }
}
