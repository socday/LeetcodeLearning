using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProductsOfArrayDiscludingSelf
{
    public class Solution
    {   
        // Ms 177, memory 66. O(n)
        public int[] ProductExceptSelf(int[] nums)
        {   
            long total = 1;
            List<int> totalEmpty= new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                total *= nums[i];
            }

            // If total = 0 => have 0 in arrays
            if (total == 0)
            {
                total = 1;
                for (int i = 0; i < nums.Length; i++)
                {
                 
                    if (nums[i] == 0)
                    {
                        totalEmpty.Add(i);
                    }
                    else
                    {
                        total *= nums[i]; 
                    }
                }
                // If there is more than 1 zero so all the ouput will be 0
                if (totalEmpty.Count > 1)
                    return new int[nums.Length];
                else 
                {// Return the default array with the total where zero locate
                    int[] returnInt = new int[nums.Length];
                    returnInt[totalEmpty.First()] = (int) total; 
                    return returnInt;
                }           
            }

            // If there is no 0 in arrays.
            else
            {
                int[] returnInt = new int[nums.Length];
                for (int i = 0; i < nums.Length; i++)
                {
                    returnInt[i] = (int)(total / nums[i]);
                }
                return returnInt;
            }
        }
    }
}
