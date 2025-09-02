using System;

public class Sol {
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

class RemoveDupArray {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Sol sol = new Sol();
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
