using System.Collections;
using System.Numerics;

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        return Solution1(nums, k);
    }

    public int[] Solution1(int[] nums, int k)
    {

        //Beat 35%, 136 ms, memory 50mb
        //Test case is random and ms and memory depent a lot on test case..
        if (nums.Length == k) return nums;
        Dictionary<int, int> d = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {   
            // Maybe time consume here.
            if (!d.ContainsKey(nums[i]))
                d[nums[i]] = 1;
            else
                d[nums[i]]++;
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

        // Tao mang theo so luong cua K
        // Sort 
        // Lay so dau tien cho no la lon nhat
        // Neu so tiep theo lon hon cho qua thu hai, neu no ra khoi mang cut
        // Error and feel ineffective.
        List<Dictionary<int, int>> list = [];
        Array.Sort (nums);
        int count = 0, temp =0;

        if (nums.Length == k) return nums;

        // Khi mang chua full add vo boi vi chac chan k phai full

        while (temp != nums.Length - 1)
        {
            while (list.Count < k)
            {
                for (int i = temp; i < nums.Length; i++)
                {
                    if (nums[i] != nums[i] + 1)
                    {
                        list.Add(new Dictionary<int, int> { { nums[i], count } });
                        temp = i;
                        count = 0;
                        break;
                    }
                    count++;
                }
            }

            while (list.Count == k)
            {
                list = list.OrderByDescending(dict => dict.Values.First()).ToList();
                for (int i = temp; i < nums.Length; i++)
                {
                    if (nums[i] != nums[i] + 1)
                    {
                        list[^1] = (new Dictionary<int, int> { { nums[i], count } });
                        temp = i;
                        count = 0;
                        break;
                    }
                    count++;
                }
            }
            
        }
        int[] keys = list.Select(dict => dict.Keys.First()).ToArray();
        return keys;
    }
}