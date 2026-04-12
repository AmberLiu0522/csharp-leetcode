/**
 * @author Amber
 * @date 2026-04-12
 * @description 
 *      88. Merge Sorted Array
 *      https://leetcode.com/problems/merge-sorted-array/description/
 */

namespace coding;

public class Class88
{
    // Time：O(m + n)
    // Space：O(1)
    public int[] MergeAndSort(int[] nums1, int m, int[] nums2, int n)
    {
        // 三个指针：分别指向 nums1有效末尾、nums2末尾、合并后总末尾
        int i = m - 1; //2
        int j = n - 1; // 2
        int k = m + n - 1; // 5

        // 从后往前放更大的数，避免覆盖
        while (i >= 0 && j >= 0)
        {
            if (nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }

        // 如果 nums2 还有剩余元素，直接全部放进 nums1
        while (j >= 0)
        {
            nums1[k] = nums2[j];
            k--;
            j--;
        }

        return nums1;
    }
}
