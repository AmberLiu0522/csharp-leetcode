using System.Globalization;

namespace coding;

/**
 * @author Amber
 * @date 2026-04-12
 * @description 
 *      27. Remove Element
 *      https://leetcode.com/problems/remove-element/description/
 */

public class Class27
{
    // Time：O(n)
    // Space：O(1)
    public int RemoveElement(int[] nums, int val)
    {
        int unequalIndex =0;

        for (int i = 0; i<=nums.Length - 1; i++)
        {   
            if(nums[i] != val)
            {
                nums[unequalIndex] = nums[i];
                unequalIndex++;
            }
            
        }

        return unequalIndex;
    }
}