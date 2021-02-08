using System;

namespace Search_a_2D_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int[][] matrix;

            //matrix = new int[][] { new int[] { 1, 3, 5, 7 }, new int[] { 10, 11, 16, 20 }, new int[] { 23, 30, 34, 60 } };
            matrix = new int[][] { new int[] { -1, 3 } };
            //matrix = new int[][] { new int[] { 1 } , new int[] { 3 } };

            // SearchMatrix(matrix,3);
            Console.WriteLine(SearchMatrix(matrix, 3));

        }



        public static bool SearchMatrix(int[][] matrix, int target)
        {

            for (int i=0;i<matrix.GetLength(0);i++)
            {

                if (matrix[i][0] <= target || matrix[i][matrix[i].Length-1] >= target)
                {

                    for(int j = 0; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == target)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }

            }

            return false;
        }



    }
}
