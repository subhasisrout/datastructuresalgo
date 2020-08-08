using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.KnapsackProblem
{
    public class KnapsackBottomUp
    {
        //Taken from https://www.youtube.com/watch?v=sVAB0p58tlg
        public int KnapsackMaxValue(int capacity, int[] weights, int[] values)
        {
            int sumOfWeights = capacity;
            int numOfWeights = weights.Length;
            int[,] matrix = new int[numOfWeights, sumOfWeights+1];
            for (int row = 0; row < numOfWeights; row++)
            {
                for (int col = 0; col <= sumOfWeights; col++)
                {
                    if (col == 0) //Special case 1
                    {
                        matrix[row, col] = 0;
                        continue;
                    }

                    if (row == 0) //Special case 2
                    {
                        if (weights[row] <= col)
                        {
                            matrix[row, col] = values[row];
                        }
                        else
                        {
                            matrix[row, col] = 0;
                        }
                        continue;
                    }

                    // General case. If you have reached here, both row and col are non-zero
                    if (weights[row] > col)
                    {
                        matrix[row, col] = matrix[row - 1, col];
                    }
                    else
                    {
                        //max of 2 parts - part 1 excluding the current weight
                        //                 part 2 including the current weight PLUS including the value of the remaining weight
                        matrix[row, col] = Math.Max(matrix[row-1,col] , values[row] + matrix[row-1, col - weights[row]]);
                    }


                }
            }
            return matrix[numOfWeights-1,sumOfWeights]; //return bottom right element of the matrix.
        }
    }
}
