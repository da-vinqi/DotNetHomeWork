using System;

namespace HomeWork2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, column;
            Console.WriteLine("请分别输入矩阵的行数和列数");
            Console.WriteLine("现在请输入矩阵的行数");
            row = int.Parse(Console.ReadLine());
            Console.WriteLine("现在请输入矩阵的列数");
            column = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row,column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.WriteLine("现在请依次输入矩阵第"+(i+1)+"行的数据");
                    matrix[i,j]=int.Parse(Console.ReadLine());
                }
            }
            PrintArray(matrix);
            if (ToeplitzMatrix())
            {
                Console.WriteLine("由上图可知该数组是托普利茨矩阵");
            }
            else Console.WriteLine("由上图可知该数组不是托普利茨矩阵");
            Console.ReadKey();

            void PrintArray(int[,] array)
            {
                try {
                    int rank1, rank2;
                    rank1 = array.GetLength(0);
                    rank2 = array.GetLength(1);
                    for(int i = 0; i < rank1 ; i++)
                    {
                        for (int j = 0; j < rank2; j++)
                        {
                            Console.Write(" " + array[i, j]);
                        if(j==rank2-1) Console.WriteLine("");
                        }
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            bool ToeplitzMatrix()
            {
                bool isToeplitzMatrix = true;
                for(int i= 0; i < row; i++)
                {
                    for(int j = 0; j < column; j++)
                    {
                        for(int k = 1; k < row; k++)
                        {
                            if (i + k > row-1 || j + k > column-1) break;
                            try {
                                if (matrix[i + k, j + k] != matrix[i, j])
                                {
                                    isToeplitzMatrix = false;
                                    return isToeplitzMatrix;
                                }
                            }
                            catch (Exception o ) {
                                Console.WriteLine(o.Message);
                            }
                        }
                    }
                }
                return isToeplitzMatrix;
            }
        }
    }
}
