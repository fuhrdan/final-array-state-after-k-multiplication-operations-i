//*****************************************************************************
//** 3264. Final Array State After K Multiplication Operations I    leetcode **
//*****************************************************************************

int* getFinalState(int* nums, int numsSize, int k, int multiplier, int* returnSize) 
{
    while (k--) 
    {
        int maxIndex = 0;
        for (int i = 1; i < numsSize; i++) 
        {
            if (nums[i] < nums[maxIndex] || 
               (nums[i] == nums[maxIndex] && i < maxIndex)) 
            {
                maxIndex = i;
            }
        }
//        printf("nums[%d] = %d * %d\n",maxIndex,nums[maxIndex],k);
        nums[maxIndex] *= multiplier;
    }

    *returnSize = numsSize;
    return nums;
}