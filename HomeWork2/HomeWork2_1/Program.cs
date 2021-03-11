using System;

namespace HomeWork2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个大于一的正整数，程序会输出其所有素数因子");
            int num;
            int count = 0;
            bool isPrime = true;
            num = int.Parse(Console.ReadLine());
            int[] primes = new int[num/ 2];
            for(int i = 2; i <= num  ; i++)
            {
                if (num % i != 0) continue;
                else
                {
                    for(int j = 2; j <= System.Math.Sqrt(i); j++)
                    {
                        if (i == 2) break;
                        if(i % j == 0)isPrime = false;
                    }
                    if (isPrime)
                    {
                        primes[count] = i;
                        count++;
                    }
                }
            }
            Console.WriteLine(num+ "的素数因子如下");    
            for(int k = 0;k< count; k++)
            {
                Console.WriteLine(primes[k]);
            }
            Console.ReadKey();
        }
    }
}
