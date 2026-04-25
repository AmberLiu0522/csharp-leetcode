using System.Linq.Expressions;

namespace coding;

/**
 * @author Amber
 * @date 2026-04-25
 * @description 
 *      169. Rotate Array
 *      https://leetcode.com/problems/rotate-array/description/
 */

 public class Class189
{
    public int[] Rotate(int[] nums, int k)
    {
        // 处理 k 超过数组长度的情况 module operation
        k = k % nums.Length;

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k-1);
        Reverse(nums, k, nums.Length - 1);

        return nums;
    }

    private void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            int element = nums[right];
            nums[right] = nums[left];
            nums[left] = element;
            left++;
            right--;
        }
    }
}