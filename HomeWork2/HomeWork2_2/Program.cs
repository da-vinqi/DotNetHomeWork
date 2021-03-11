using System;

namespace HomeWork2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("请输入您想要的数组的大小，并接下来依次输入想要填入的数据");
            size = int.Parse(Console.ReadLine());
            int[] nums = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("现在输入第"+(i + 1)+"个数据");
                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
            }
            int max, sum, min, ave;
            sum = 0;
            ave = 0;
            max = nums[0];
            min = nums[0];
            Console.WriteLine("该数组中的最大值为："+Max()+" 最小值为："+Min()+" 平均值为："+Ave()+" 总和为："+Sum());
            Console.ReadKey();

            int Max()
            {
                for (int j = 0; j < size; j++)
                {
                    max = nums[j] > max ? nums[j] : max;
                }
                return max;
            }
            int Min()
            {
                for(int k = 0; k < size; k++)
                {
                    min = nums[k] < min ? nums[k] : min;
                }
                return min;
            }
            int Sum()
            {
                foreach(int numb in nums)
                {
                    sum += numb;
                }
                return sum;
            }
            int Ave()
            {
                foreach(int numb in nums)
                {
                    ave += numb;
                }
                ave = ave / size;
                return ave;
            }
        }
    }
}
