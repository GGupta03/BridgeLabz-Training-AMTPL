/*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
Example 
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
Example 1:
Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].*/

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> set = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (set.ContainsKey(target - nums[i]))
            {
                return new int[] { set[target - nums[i]], i };
            }
            else
            {
                set.Add(nums[i], i);
            }
        }
        return new int[] { -1, -1 };
    }
}
