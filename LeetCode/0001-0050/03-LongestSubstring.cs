namespace LeetCode._0001_0050
{
    public class _03_LongestSubstring
    {
        // Sliding Window algorithm.
        // 55 ms runtime, 43.13 MB of memory.
        public int LengthOfLongestSubstring_SlidingWindow(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            var map = new Dictionary<int, int>();
            var maxLen = 0;
            var lastRepeatPos = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]) && lastRepeatPos < map[s[i]])
                    lastRepeatPos = map[s[i]];
                if (maxLen < i - lastRepeatPos)
                    maxLen = i - lastRepeatPos;
                map[s[i]] = i;
            }

            return maxLen;
        }

        // Sliding window alternative. Uses more memory probably because it operates on the string/substring.
        // 55 ms runtime, 59.57 MB of memory.
        public int LengthOfLongestSubstring_SlidingWindow_Alternative(string s)
        {
            int max = s.Length > 0 ? 1 : 0;
            int pointer = 0;
            string sub = String.Empty;
            while (pointer < s.Length)
            {
                if (sub.Contains(s[pointer]))
                {
                    max = max < sub.Length ? sub.Length : max;
                    sub = sub.Remove(0, sub.IndexOf(s[pointer]) + 1);
                }
                sub += s[pointer];
                pointer++;
                if (pointer == s.Length)
                {
                    max = max < sub.Length ? sub.Length : max;
                }
            }
            return max;
        }

        // Brute force solution, which is bad.
        // 124 ms runtime, 120.93 MB of memory.
        public int LengthOfLongestSubstring_BruteForce(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            var longestSubstringLength = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var uniqueChars = new Dictionary<char, int>();
                var currentSubstringLength = 0;
                var currentIndex = i;

                while ((currentIndex) < s.Length && !uniqueChars.ContainsKey(s[currentIndex]))
                {
                    uniqueChars.Add(s[currentIndex], currentIndex);
                    currentSubstringLength++;
                    currentIndex++;
                }

                if (currentSubstringLength > longestSubstringLength) longestSubstringLength = currentSubstringLength;
            }

            return longestSubstringLength;
        }
    }
}
