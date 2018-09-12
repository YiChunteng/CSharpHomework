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
            int a, b;
            Console.WriteLine("请输入两个数字：");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("输出结果：");
            int c = a * b;
            Console.Write(c);
        }
    }
}
