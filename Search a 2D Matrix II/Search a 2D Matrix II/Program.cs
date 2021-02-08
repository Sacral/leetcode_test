using System;
using System.Collections.Generic;

namespace Search_a_2D_Matrix_II
{
    class Program
    {
        static void Main(string[] args)
        {

           int[][] matrix;
                
           // matrix = new int[][] { new int[] { 1, 4, 7, 11, 15 }, new int[] { 2, 5, 8, 12, 19 }, new int[] { 3, 6, 9, 16, 22 }, new int[] { 10, 13, 14, 17, 24 }, new int[] { 18, 21, 23, 26, 30 } };

            matrix = new int[][] { new int[] { -1, 3  } };

            // int[,] matrix =  { { 1, 4, 7, 11, 15 },{ 2, 5, 8, 12, 19 },  { 3, 6, 9, 16, 22 },  { 10, 13, 14, 17, 24 },  { 18, 21, 23, 26, 30 } };



            Console.WriteLine(SearchMatrix(matrix,3));
        }

        public static bool SearchMatrix(int[][] matrix, int target)
        {

            int nums_index = 0;

            //行數
            /* for(int i =0; i < matrix.Length; i++)
             {

                 Console.WriteLine(matrix.ToString());

                     if (matrix.Equals (target))
                     {
                         return true;
                     }


             }*/

            for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {

                if (matrix[i].Length > 0)
                {
                    for (int j = 0; j <= matrix[i].Length - 1; j++)
                    {
                        if (matrix[i][j] == target)
                        {
                            return true;
                        }
                    }

                }
                else
                {

                    if (matrix[0][i] == target)
                    {
                        return true;
                    }
                }


               // Console.WriteLine(matrix[i].ToString());

            }




            return false;
        }


    }
}
