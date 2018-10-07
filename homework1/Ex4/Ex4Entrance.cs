using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Ex4Entrance
    {
        static void Main(string[] args)
        {
            double s = 0;
            Console.WriteLine("请输入两个数，我们将计算两个数的积");
            Console.WriteLine("请输入第1个数:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第2个数:");
            double b = double.Parse(Console.ReadLine());
            s = a * b;
            Console.WriteLine("两数之积为：{0}", s);
        }
    }
}
