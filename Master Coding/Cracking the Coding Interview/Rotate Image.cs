using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Coding.Cracking_the_Coding_Interview
{
    public static class Rotate_Image
    {
        public static void Rotate(int[][] matrix)
        {
            int c = 1;
            var len = matrix[0].Length;
            var index = len - 1;
            for (var j = 0; j < len/2; j++)
            {

                for (var i = 0; i < len - j-c; i++)
                {
                    Swap(matrix, j, j + i, index - i-j, j);

                    Swap(matrix, index - i-j, j, index-j, index - i-j);

                    Swap(matrix, index - j, index - i-j, j + i, index-j);

                }
                c++;
            }
                

        }

        static void Swap(int[][] matrix, int i, int j, int k, int l)
        {
            var temp = matrix[i][j];
            matrix[i][j] = matrix[k][l];
            matrix[k][l] = temp;
        }
    }
}
