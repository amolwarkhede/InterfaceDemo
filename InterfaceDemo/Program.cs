using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface I1  
    {
        void Add();
        void sub();
    }
    interface I2
    {
        void Mul();
        void Div();
    }


   class Program : I1,I2
    {
        public void Add()
        {
            int a = 10;
            int b = 20;

            int c = a + b;
            Console.WriteLine("calling Add");
        }

        public void sub()
        {
            int a = 10;
            int b = 20;

            int c = a + b;
            Console.WriteLine("calling Sub");
        }

        public void Mul()
        {
            int a = 10;
            int b = 20;

            int c = a + b;
            Console.WriteLine("calling Mul");
        }

        public void Div()
        {
            int a = 10;
            int b = 20;

            int c = a + b;
            Console.WriteLine("calling Div");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Add();
            p.Mul();
            p.Div();
            p.sub();
            Console.ReadLine();
        }

    
    }
}
