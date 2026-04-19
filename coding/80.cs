
/**
 * @author Amber
 * @date 2026-04-19
 * @description 
 *      80. Remove Duplicates from Sorted Array II
 *      https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/description/
 */
public class Class80
{
    // Time complexity: O(n)
    // Space complexity: O(1)
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1;
        int count = 1;

        if(nums.Length <= 1)
        {
            return k;
        }

        for (int i = 1; i<= nums.Length - 1; i++)
        {
            if(nums[i] == nums[i - 1])
            {
                if(count < 2 && count > 0)
                {
                    nums[k] = nums[i];
                    k++;
                    count++;
                }
                else
                {
                    count = -1;
                }
            }
            else
            {
                nums[k] = nums[i];
                k++;
                count = 1;
            }
        }
        return k;
    }
}