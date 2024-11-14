public class Solution {
    public int[] TwoSum(int[] nums, int target) {
     int sum=0;
     int[] indices = new int[2];
     for(int i=0;i<nums.Length;i++)
     {
        for(int j=1;j<nums.Length;j++)
        {
            sum = nums[i] + nums [j];
            if(sum == target)
            {
                indices[0] = i;
                indices[1] = j;
                break;
            }
        }
        if(sum == target)
        {
            break;
        }
      }
      return indices;
    }
}