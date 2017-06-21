using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalArguments
{

    class OptionalArgsDemo
    {
        public void OptArgsMeth(int a , int b =10, int c = 100)
        {

            Console.WriteLine("Value of 1st argument: {0} ,Value of 2nd argument: {1} ,Value of 3rd argument: {2}", a, b, c);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            OptionalArgsDemo obj = new OptionalArgsDemo();
            obj.OptArgsMeth(1);
            obj.OptArgsMeth(1,2);
            obj.OptArgsMeth(1,2,3);
            Console.Read();
        }
    }
}
