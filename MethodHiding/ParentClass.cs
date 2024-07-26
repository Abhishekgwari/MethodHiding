using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class ParentClass
    {
        public virtual void test1()            // Using method overriding
        {
            Console.WriteLine("Method Test1 from parent class");
        }
        public void test2()           // Using method Hiding/ Shadowing
        {
            Console.WriteLine("Method Test2 from parent class");
        }
    }
    class Childclass : ParentClass
    {
        public override void test1()
        {
            Console.WriteLine("Method Test1 from child class");
        }
        public new void test2()
        {
            Console.WriteLine("Method Test2 from child class");
        }
        public void ParentTest1()
        {
            base.test1();
        }

        public void ParentTest2()
        {
            base.test2();
        }
        static void Main()
        {
            
            
            Childclass c = new Childclass();           // c is instance of child class
            ParentClass p = c;  //p is refrence  of parent class created by using child's class

            p.test1(); // invoke child class method
            p.test2(); // invoke parent class parent class
           
            c.ParentTest1();
            c.ParentTest2();
            c.test1();
            c.test2();

            Console.ReadLine();
        }
    }
}
