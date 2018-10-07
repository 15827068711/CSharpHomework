using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Num;
            Num = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Please inpute the int No." + (i + 1) + ":");
                Num[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("素数有：");
            for (int j = 0; j < 10; j++)
            {
                int flag = 0;
                for (int k = 2; k * k < Num[j]; k++)
                {
                    if (Num[j] % k == 0) flag = 1;
                }
                if (flag == 0) Console.Write(Num[j] + "  ");
            }
            Num = null;
        }
    }
}