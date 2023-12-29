using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Converting double to int

            double a = 3.14;
            int b = Convert.ToInt32(a);    

            //Converting int to double/decimal

            int c = 3;
            double d = Convert.ToDouble(c) + 0.1;

            //Converting int to string

            int e = 400;
            String f = Convert.ToString(e);

            //Converting string to char

            String g = "#";
            char h = Convert.ToChar(g);

            //Converting string to boolean

            String i = "false";
            bool j = Convert.ToBoolean(i);

            Console.WriteLine(b.GetType());
            Console.WriteLine(d.GetType());
            Console.WriteLine(f.GetType());
            Console.WriteLine(h.GetType()); 
            Console.WriteLine(j.GetType());

            Console.ReadKey();
        }
    }
}