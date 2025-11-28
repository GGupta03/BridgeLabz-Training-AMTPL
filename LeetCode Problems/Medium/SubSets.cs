/*Given an integer array nums of unique elements, return all possible subsets (the power set).
The solution set must not contain duplicate subsets. Return the solution in any order.
Example 1:
Input: nums = [1, 2, 3]
Output: [[],[1],[2],[1, 2],[3],[1, 3],[2, 3],[1, 2, 3]]
Example 2:
Input: nums = [0]
Output: [[],[0]]*/

public class solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {

        List<IList<int>> result = new List<IList<int>>();
        List<int> current = new List<int>();

        GenerateSubsets(nums, 0, current, result);
        return result;
    }

    private void GenerateSubsets(int[] nums, int index, List<int> current, List<IList<int>> result)
    {
        result.Add(new List<int>(current));

        for (int i = index; i < nums.Length; i++)
        {
            current.Add(nums[i]);

            GenerateSubsets(nums, i + 1, current, result);

            current.RemoveAt(current.Count - 1);
        }
    }
}
