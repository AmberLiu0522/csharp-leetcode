/**
 * @author Amber
 * @date 2026-04-12
 * @description 
 *      26. Remove Duplicates from Sorted Array
 *      https://leetcode.com/problems/remove-duplicates-from-sorted-array/description/
 */

public class Class26
{
    // Time：O(n)
    // Space：O(1)
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1;

        if(nums.Length <= 1)
        {
            return k;
        }

        for(int i=1; i <= nums.Length - 1; i++)
        {
            if(nums[i] != nums[i - 1])
            {
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}