using System.Collections;
using System.Numerics;

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return Solution1(nums, k);
    }

    public int[] Solution1(int[] nums, int k)
    {
        //Mot mang chua so va so luong count
        // So nao nhieu hon thi len dau
        // Tra lai mang theo so luong tu dau den k

        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!d.ContainsKey(nums[i]))
            {
                d.Add(nums[i], 1);
            }
            else
            {
                d[nums[i]]++;
            }

        }
        return d.OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }

    public int[] Solution2(int[] nums, int k)
    {
        //Mot mang chua so va so luong count
        // So nao nhieu hon thi len dau
        // Tra lai mang theo so luong tu dau den k

        //Tao mang theo so luong cua K
        // Sort 
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!d.ContainsKey(nums[i]))
            {
                d.Add(nums[i], 1);
            }
            else
            {
                d[nums[i]]++;
            }

        }
        return d.OrderByDescending(x => x.Value)
            .Take(k)
            .Select(x => x.Key)
            .ToArray();
    }
}