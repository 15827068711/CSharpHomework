using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace homework3
{
    public abstract class BaseProdImag//定义一个抽象图形基类
    {
        public abstract void draw();//创建图形
        public abstract double S();//求图形的面积
        public void erase()//删除图形
        {
            Console.WriteLine("擦除图形");
        }
    }
    public class Circle : BaseProdImag//创建圆形
    {
        double radius;
        public void GetInfor1(double[] Infor)//获取圆周的半径
        {
            radius = Infor[0];
        }
        public override void draw()//重写创建函数
        {

        }
        public override double S()
        {
            double res = radius * radius * 3.14;
            return res;
        }

    }
    public class Rect : BaseProdImag//创建矩形
    {
        double length, width;
        public void GetInfor2(double[] Infor)
        {
            length = Infor[0];
            width = Infor[1];
        }
        public override void draw()
        {

        }
        public override double S()
        {
            double res = length * width;
            return res;
        }
    }
    public class Square : BaseProdImag//创建正方形
    {
        double sidesL;
        public void GetInfor3(double[] Infor)
        {
            sidesL = Infor[0];
        }
        public override void draw()
        {

        }
        public override double S()
        {
            double res = sidesL * sidesL;
            return res;
        }
    }
    public class Triang : BaseProdImag//创建三角形
    {
        double side1, side2, side3;
        public void GetInfor4(double[] Infor)
        {
            side1 = Infor[0];
            side2 = Infor[1];
            side3 = Infor[2];
        }
        public override void draw()
        {

        }
        public override double S()
        {
            if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
            {
                double p = (side1 + side2 + side3) / 2;
                double e = Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
                return e;
            }
            else
            {
                Console.WriteLine("不存在该三角形");
                return 0;
            }
        }
    }
    public class ImagFactory//工厂类，用来生产图形
    {
        public static BaseProdImag CreateImag(string imagname, double[] Infor)
        {
            switch (imagname)
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rect();
                case "square":
                    return new Square();
                case "Triangle":
                    return new Triang();
                default:
                    return new Rect();

            }

        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            BaseProdImag image = ImagFactory.CreateImag("circle", new double[1] { 3 });
            image.draw();
            image.S();
        }
    }
}

