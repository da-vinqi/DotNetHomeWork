using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            double a, b;
            char n;
            Console.WriteLine("请输入两个数字以及想要完成的运算");
            Console.WriteLine("现在请输入第一个数字");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("现在请输入第二个数字");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("现在请输入相应的运算符");
            n = char.Parse(Console.ReadLine());
            switch (n)
            {
                case '+':
                    Console.WriteLine($"最终的结果为{a + b}");
                    break;
                case '-':
                    Console.WriteLine($"最终的结果为{a - b}");
                    break;
                case '*':
                    Console.WriteLine($"最终的结果为{a * b}");
                    break;
                case '/':
                    Console.WriteLine($"最终的结果为{a / b}");
                    break;
            }
        }
    }
}
