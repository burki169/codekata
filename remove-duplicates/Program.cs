
 int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2)
            return nums.Length;
		
        int index = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1])
            {
                nums[index] = nums[i];
                index++;
            }
        }
        return index;
    }
    
 int[] nums = [1,1,2]; // Input array
 int[] expectedNums = [1,2]; // The expected answer with correct length

 int k = RemoveDuplicates(nums); // Calls your implementation

 for (int i = 0; i < k; i++) {
     if(nums[i] != expectedNums[i])
         Console.WriteLine("Failed");
 }
