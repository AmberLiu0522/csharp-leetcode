namespace coding;

/**
 * @author Amber
 * @date 2026-04-25
 * @description 
 *      169. Majority Element
 *      https://leetcode.com/problems/majority-element/description/
 */

 public class Class169
{
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int candidate = 0;

        foreach (int num in nums)
        {
          if(count == 0)
            {
                candidate = num;
            }   

            if(candidate == num)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        
        return candidate;
    }
}