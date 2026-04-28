namespace Dummy;

public static class Helper
{
    public static void PrintArray(this int[] arr)
    {
        Console.WriteLine(string.Join(", ", arr));
    }
}
public class Solution
{
    private bool CompareValue(Dictionary<char, int> dict, string s)
    {
        foreach (KeyValuePair<char, int> entry in dict)
        {
            Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
        }
        Dictionary<char, int> copy = new Dictionary<char, int>(dict);
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (copy.ContainsKey(c) && copy[c] > 0)
            {
                copy[c] = copy[c] - 1;
            }
            else
            {   
                return false;
            }
        }
        foreach (KeyValuePair<char, int> entry in copy)
        {
            if (entry.Value > 0)
            {
                return false;
            }
        }
        return true;
    }
    public bool CheckInclusion(string s1, string s2)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < s1.Length; i++)
        {
            if (dict.ContainsKey(s1[i]))
            {
                dict[s1[i]] = dict[s1[i]] + 1;
            }
            else
            {
                dict[s1[i]] = 1;
            }
        }
        int k = s1.Length;
        for (int i = 0; i < s2.Length - k + 1; i++)
        {
            Console.WriteLine(s2.Substring(i, k));
            bool exists = CompareValue(dict, s2.Substring(i, k));
            if (exists)
            {
                return exists;
            }
        }

        return false;

    }
        private bool IsAnagram(string p, string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();

        for (int i = 0; i < p.Length; i++)
        {
            if (dict.ContainsKey(p[i]))
            {
                dict[p[i]] = dict[p[i]] + 1;
            }
            else
            {
                dict[p[i]] = 1;
            }
         }
        return CompareValue(dict, s);
    }
    public IList<int> FindAnagrams(string s, string p) {
        List<int> output = new List<int>();
        int k = p.Length;

        for(int i = 0; i < s.Length - k + 1; i++)
        {
            if (IsAnagram(s.Substring(i,k), p))
            {
                output.Add(i);
            }
        }
        return output;
    }

    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0)
        {
            return 0;
        }
        int maxLen = 0;
        int l = 0;

        Dictionary<char,int> record = new Dictionary<char, int>();

        for(int r = 0; r < s.Length; r++)
        {
            char c = s[r];
            if( record.ContainsKey(c) && record[c] >= l)
            {
                l = record[c] + 1;
            }
            
            record[c] = r;
            maxLen = Math.Max(maxLen, r-l+1);
        }
       return maxLen;
    }

    public class NumArray {

    private int[] prefix;
    public NumArray(int[] nums) {
        prefix = new int[nums.Length + 1];
        for(int i = 0; i < nums.Length; i++)
        {
            prefix[i + 1] = prefix[i] + nums[i];
        }
    }
    
    public int SumRange(int left, int right) {
        return prefix[right + 1] - prefix[left];
    }
}




}

public class DifferenceArray
{
    private int[] diff;
    private int n;

    public DifferenceArray(int[] nums)
    {
        n = nums.Length;
        diff = new int[n + 1]; // extra slot so r+1 never goes out of bounds

        // Build difference array from original
        diff[0] = nums[0];
        for (int i = 1; i < n; i++)
            diff[i] = nums[i] - nums[i - 1];

       System.Console.WriteLine("Difference array: " + string.Join(", ", diff));     
    }

    // Range update: add val to every element in [l..r] — O(1)
    public void RangeAdd(int l, int r, int val)
    {
        diff[l]     += val;   // effect starts at l
        diff[r + 1] -= val;   // effect stops after r
        System.Console.WriteLine("After range update [" + l + ", " + r + "]: " + string.Join(", ", diff));
    }

    // Rebuild the final array after all updates — O(n), call once
    public int[] Rebuild()
    {
        int[] result = new int[n];
        result[0] = diff[0];
        for (int i = 1; i < n; i++)
            result[i] = result[i - 1] + diff[i]; // prefix sum over diff
        System.Console.WriteLine("Rebuilt array: " + string.Join(", ", result));
        return result;
    }
}