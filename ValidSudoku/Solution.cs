using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ValidSudoku
{
    internal class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            // Run diagonal, check if each number in column, row is unique.
            // Then run in each box to check if it valid.
            int size = 9;
            int k =0;
            // Check diagonal
            while (k < size)
            {   
                // For check, we will count each number of a column, row to array, if we have duplicate return false.
                int[] iRow = new int [10];
                int[] iColumn = new int[10];

                
                    for (int i = 0; i < size; i++)
                    {
                        // Check Row
                        // Get number
                        int tempRow = (int)char.GetNumericValue(board[k][i]);
                        // Add number
                        if (tempRow > -1)
                        {
                            iRow[tempRow]++;
                            // Return false 
                            if (iRow[tempRow] > 1) return false;
                    }

                        // Check Column
                        // Get number
                        int tempColumn = (int)char.GetNumericValue(board[i][k]);
                        // Add number
                        if (tempColumn > -1)
                        {
                            iColumn[tempColumn]++;
                            // Return false 
                            if (iColumn[tempColumn] > 1) return false;
                    }
                        //Console.WriteLine($"Current position row is: {k} {i} Value: {board[k][i]} || column is: {i} {k} Value: {board[i][k]}" );
                    }
                
                // Next diagonal
                //Console.WriteLine($"Current row is {string.Join(",", iRow)}");
                //Console.WriteLine($"Current column is {string.Join(",", iColumn)}");

                k++;
            }
            // Check each box
            k = 3;
            while (k <= size)
            {
                int[] iBox = new int [10];
                for (int i = k-3; i < k; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.WriteLine($"Current position board is: {j},{i}| Value {board[j][i]}");

                        int tempBox = (int)char.GetNumericValue(board[j][i]);
                        // Add number
                        if (tempBox > -1)
                        {
                            iBox[tempBox]++;
                       
                        // Return false 
                        if (iBox[tempBox] > 1) return false;
                        }
         
                    }
                }
                Console.WriteLine($"iBox : is {string.Join(",", iBox)}");
                k += 3;
            }
          
            return true;
        }
    }
}
