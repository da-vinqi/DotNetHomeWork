using System;

namespace HomeWork2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primes = new int[99];
            for(int i = 0; i < 99; i++)
            {
                primes[i] = i + 2;
            }
            primes = EhrlichSieveMethod();
            Console.WriteLine("2--100以内的素数为");
            foreach (int prime in primes)
            {
                if(prime != 0)
                Console.WriteLine(prime);
            }
            Console.ReadKey();


            int[] EhrlichSieveMethod()
            {
                for (int j = 0; j < 99; j++)
                {
                    if (primes[j] == 0) continue;
                    for(int k = j + 1; k < 99; k++)
                    {
                        if (primes[k] % primes[j] != 0) continue;
                        primes[k] = 0;
                    }
                }
                return primes;
            }
        }
    }
}
