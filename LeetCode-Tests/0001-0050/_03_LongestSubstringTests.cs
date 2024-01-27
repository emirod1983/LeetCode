using LeetCode._0001_0050;

namespace LeetCode_Tests._0001_0050
{
    public class _03_LongestSubstringTests
    {
        private _03_LongestSubstring Sut {  get; set; }

        public _03_LongestSubstringTests()
        {
            this.Sut = new _03_LongestSubstring();
        }

        public class TheMethod_LengthOfLongestSubstring_SlidingWindow : _03_LongestSubstringTests
        {
            [Theory]
            [InlineData("abcabcbb", 3)]
            [InlineData("bbbbb", 1)]
            [InlineData("pwwkew", 3)]
            [InlineData("asdasdasdasdasdf", 4)]
            public void Should(string input, int expected)
            {
                var result = Sut.LengthOfLongestSubstring_SlidingWindow(input);

                result.Should().Be(expected);
            }
        }


        public class TheMethod_LengthOfLongestSubstring_SlidingWindow_Alternative : _03_LongestSubstringTests
        {
            [Theory]
            [InlineData("abcabcbb", 3)]
            [InlineData("bbbbb", 1)]
            [InlineData("pwwkew", 3)]
            [InlineData("asdasdasdasdasdf", 4)]
            public void Should(string input, int expected)
            {
                var result = Sut.LengthOfLongestSubstring_SlidingWindow_Alternative(input);

                result.Should().Be(expected);
            }
        }

        public class TheMethod_LengthOfLongestSubstring_BruteForce : _03_LongestSubstringTests
        {
            [Theory]
            [InlineData("abcabcbb", 3)]
            [InlineData("bbbbb", 1)]
            [InlineData("pwwkew", 3)]
            [InlineData("asdasdasdasdasdf", 4)]
            public void Should(string input, int expected)
            {
                var result = Sut.LengthOfLongestSubstring_BruteForce(input);

                result.Should().Be(expected);
            }
        }
    }
}
