using System;

namespace HomeWork3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5,6);
            Square square = new Square(4);
            Triangle triangle = new Triangle(3,4,5);
            rectangle.isLegal();
            rectangle.Area();
            square.isLegal();
            square.Area();
            triangle.isLegal();
            triangle.Area();
            Console.ReadKey();

            Random random = new Random();
            Double areaSum = 0;
            Console.WriteLine("0代表矩形，需要两个参数；1代表正方形，需要一个参数；" +
                "2代表三角形，需要三个参数");
            for (int i = 0 ; i < 10 ; i++)
            {
                int num = random.Next(0, 3);
                Product product = Factory.CreateProduct(num);
                areaSum += product.Area();
            }
            Console.WriteLine("这十个对象的面积之和为"+areaSum);
            Console.ReadKey();
        }
        class Rectangle : Product, LegalJudge, AreaCal
        {
            private int length { set; get; }
            private int width { set; get; }

            public Rectangle(int length, int width)
            {
                this.length = length;
                this.width = width;
            }

            public bool isLegal()
            {
                Console.WriteLine("该矩形合法");
                return true;
            }

            override public double Area() 
            {
                int s = length * width;
                Console.WriteLine("该矩形的面积为"+s);
                return s;
            }

        }
        class Square : Product, LegalJudge, AreaCal
        {
            private int sideLength { set; get; }

            public Square(int side)
            {
                this.sideLength = side;
            }
            public bool isLegal()
            {
                Console.WriteLine("该正方形合法");
                return true;
            }
            override public double Area()
            {
                int s = sideLength * sideLength;
                Console.WriteLine("该正方形的面积为"+s);
                return s;
            }

        }

        class Triangle:Product,LegalJudge,AreaCal
        {
            private int side1Length { set; get; }
            private int side2Length { set; get; }
            private int side3Length { set; get; }

            public Triangle(int side1,int side2,int side3)
            {
                this.side1Length = side1;
                this.side2Length = side2;
                this.side3Length = side3;
            }
            public bool isLegal() 
            {
                if (side1Length + side2Length > side3Length &&
                    side2Length + side3Length > side1Length &&
                    side1Length + side3Length > side2Length)
                {
                    Console.WriteLine("此三边长度可以构成三角形");
                    return true;
                }
                else
                {
                    Console.WriteLine("此三边长度构不成三角形");
                    return false;
                }
            }

            override public double Area() 
            {
                double p = 0.5 * (side1Length + side2Length + side3Length);
                double s = Math.Sqrt((p * (p - side1Length) * (p - side2Length) * (p - side3Length)));
                Console.WriteLine("该三角形的面积为"+s);
                return s;
            }

        }
        interface LegalJudge {
            bool isLegal();
        }

        interface AreaCal
        {
            double Area();
        }

        abstract class Product 
        {
            public abstract double Area();
        }

        class illegalException : Exception { }
        class Factory 
        {
            public static Product CreateProduct(int which)
            {
                switch (which)
                {
                    case 0:
                        try {
                            Console.WriteLine("现在请输入两个参数");
                            int num1 = int.Parse(Console.ReadLine());
                            int num2 = int.Parse(Console.ReadLine());
                            return new Rectangle(num1, num2);
                        }
                        catch (System.FormatException o ) {
                            Console.WriteLine("参数输入错误，请重新输入两个参数");
                            int num1 = int.Parse(Console.ReadLine());
                            int num2 = int.Parse(Console.ReadLine());
                            return new Rectangle(num1, num2);
                        }
                    case 1:
                        try {
                            Console.WriteLine("现在请输入一个参数");
                            int num = int.Parse(Console.ReadLine());
                            return new Square(num);
                        }
                        catch (System.FormatException o)
                        {
                            Console.WriteLine("参数输入错误，请重新输入一个参数");
                            int num = int.Parse(Console.ReadLine());
                            return new Square(num);
                        }
                        
                    case 2:
                        try
                        {
                            Console.WriteLine("现在请输入三个参数");
                            int triNum1 = int.Parse(Console.ReadLine());
                            int triNum2 = int.Parse(Console.ReadLine());
                            int triNum3 = int.Parse(Console.ReadLine());
                            if(!new Triangle(triNum1, triNum2, triNum3).isLegal())
                            {
                                throw new illegalException();
                            }
                            return new Triangle(triNum1, triNum2, triNum3);
                        }
                        catch(illegalException e)
                        {
                            Console.WriteLine("此三边构不成三角形，请重新输入三个参数");
                            int triNum1 = int.Parse(Console.ReadLine());
                            int triNum2 = int.Parse(Console.ReadLine());
                            int triNum3 = int.Parse(Console.ReadLine());
                            return new Triangle(triNum1, triNum2, triNum3);
                        }
                        catch (System.FormatException o)
                        {
                            Console.WriteLine("参数输入错误，请重新输入三个参数");
                            int triNum1 = int.Parse(Console.ReadLine());
                            int triNum2 = int.Parse(Console.ReadLine());
                            int triNum3 = int.Parse(Console.ReadLine());
                            return new Triangle(triNum1, triNum2, triNum3);
                        }
                        
                    default:
                        Console.WriteLine("参数错误，请重新输入");
                        return null;
                }
            }
        }

    }
}
