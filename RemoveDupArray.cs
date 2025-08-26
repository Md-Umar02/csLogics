using System;

public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;

        int k = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > nums[i - 1]) {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}

class Program {
    static void Main() {
        int[] nums = { 0,0,1,1,1,2,2,3,3,4 };

        Solution sol = new Solution();
        int k = sol.RemoveDuplicates(nums);

        Console.WriteLine("k = " + k);

        Console.Write("nums = [");
        for (int i = 0; i < nums.Length; i++) {
            if (i < k)
                Console.Write(nums[i]); // unique part
            else
                Console.Write("_");     // filled part
            if (i < nums.Length - 1) Console.Write(",");
        }
        Console.WriteLine("]");
    }
}
