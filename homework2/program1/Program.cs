using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = Convert.ToInt64(Console.ReadLine());
            int i = 2;
            while (num != 1)
            {
                while (num % i == 0)
                {
                    num = num / i;
                    Console.Write(i + "  ");
                }
                i++;
            }


        }
    }
}
