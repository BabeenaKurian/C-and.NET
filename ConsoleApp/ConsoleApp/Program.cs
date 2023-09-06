using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 s1 = new Class1();
            s1.findMax(14, 12); // calling method by passing two values
            s1.findMax(a: 14, b: 12); // calling method specifying the parameters by name.
        }
}
