public class Solution {
    public int MaxSubArray(int[] nums) 
    {
        int n = nums.Length, maxSum = nums[0];
        for(int i = 1; i < n; ++i) 
        {
          if (nums[i - 1] > 0) nums[i] += nums[i - 1];
          maxSum = Math.Max(nums[i], maxSum);
        }
        return maxSum;
    }
}