using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GotoEndExample
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            doApp();  
            Console.ReadKey();

        }
        static void doApp()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 6)
                {
                    goto end;
                }
                Console.WriteLine("i value:{0}", i);
            }
        end: Console.WriteLine("The end");
        }
    }
}
