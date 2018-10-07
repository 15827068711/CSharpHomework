using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Num;
            int Max, Min, Total, Ave, N;
            Num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Please inpute the int No." + (i + 1) + ":");
                Num[i] = int.Parse(Console.ReadLine());
            }
            Max = Num[0]; Min = Num[0]; Total = 0; Ave = 0; N = 0;
            foreach (int i in Num)
            {
                Total += i;
                if (i > Max) Max = i;
                if (i < Min) Min = i;
                N++;
            }
            Ave = Total / N;
            Console.WriteLine("最大值为：" + Max);
            Console.WriteLine("最小值为：" + Min);
            Console.WriteLine("所有数组元素的和为：" + Total);
            Console.WriteLine("所有数组元素的平均值为：" + Ave);
            Num = null;
        }
    }
}

