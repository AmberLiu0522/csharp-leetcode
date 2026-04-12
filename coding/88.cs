/**
 * @author Amber
 * @date 2024-06-01
 * @description 
 *      88. Merge Sorted Array
 *      https://leetcode.com/problems/merge-sorted-array/description/
 */

namespace coding;

public class Class88
{
    // 时间复杂度：O((m+n) log(m+n))
    // 空间复杂度：O(m+n)
    public int[] MergeAndSort(int[] nums1, int m, int[] nums2, int n)
    {
        var nums1Length = nums1.Length;
        var nums2Length = nums2.Length;

        // Validation
        if(m < 0 || n < 0) {
            throw new ArgumentException("m and n should be non-negative.");
        }

        if (m > nums1Length || n > nums2Length) {
            throw new ArgumentException("m and n should be less than or equal to the length of nums1 and nums2 respectively.");
        }

        // Retrieve the valid parts of nums1 and nums2
        var validNums1 = nums1.Take(m).ToArray();
        var validNums2 = nums2.Take(n).ToArray();

        // Merge the two valid parts
        var mergedArray = validNums1.Concat(validNums2).ToArray();

        // Sort the merged array
        Array.Sort(mergedArray);

        return mergedArray;
    }

    // 时间复杂度：O(m + n)
    // 空间复杂度：O(1)
    public int[] Merge(int[] nums1, int m, int[] nums2, int n)
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
