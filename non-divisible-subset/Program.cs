class Solution
{
    public static int nonDivisibleSubset(int k, List<int> s)
    {
        if (k == 1 || s.Count == 0)
            return 0;
        if (s.Count == 1)            
            return s[0]%k == 0 ? 0 : 1;
        
        int[] remainders = new int[k];
        for (int i = 0; i < s.Count; i++)
        {
            var r = s[i] % k;
            remainders[r]++;
        }

        int sum = remainders[0] > 0 ? 1 : 0;     
        for (int i = 1; i <= k / 2; i++)
        {
            if (i == k - i) 
            {
                sum += Math.Min(remainders[i], 1);
            }
            else
            {
                sum += Math.Max(remainders[i], remainders[k - i]);
            }
        }

        return sum;
    }
    public static void Main(string[] args)
    {

        // Test case 1
        Console.WriteLine(nonDivisibleSubset(4, [1, 7, 2, 5, 3, 11, 6 ]));
      

    }
}
