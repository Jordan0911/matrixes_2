namespace matrixes_2
{
    internal class Program
    {
      
        static bool Palindrome_sum(int[,] matrix)
        {
            int sum1 = 0, sum2 = 0;
         




















            return false;
        }
        static bool Edge_checker(int[,] matrix)
        {
            int sum = 0, sample = matrix[0,0],l=0,h=0,n;
            
   
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i == 0 || i == matrix.GetLength(0))
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if(matrix[i,j] == sample)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    if (matrix[i, 0] != sample || matrix[i, matrix.GetLength(0)] != sample)
                    {
                        return true;
                    }
                }
            }
            return false;
               
               
                
               
            









            return false;
        }
        static bool Diagonal_sum(int[,] matrix)
        {
            int sum1 = 0,sum2=0,result=0;
           
            for (int i = matrix.GetLength(0); i >= 0; i--)
            {
                sum1 += matrix[i, i];
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum2 += matrix[i, i];
            }
            if (sum1 == sum2)
            {
                return true;
            }
            return false;
        }
        static bool Search_number(double[,] matrix, double min,double max)
        {
            int n = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > min && matrix[i,j]<max)
                    {
                        n++;
                    }
                }
            }
               if(n==matrix.GetLength(0)* matrix.GetLength(1))
               {
                    return true;
               }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
