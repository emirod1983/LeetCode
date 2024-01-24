using LeetCode._0001_0050;

namespace LeetCode_Tests
{
    public class _01_TwoSum_Tests
    {
        private _01_TwoSum Sut {  get; set; }

        public _01_TwoSum_Tests()
        {
            this.Sut = new _01_TwoSum();
        }

        public class TheMethod_TwoSum : _01_TwoSum_Tests
        {
            [Theory]
            [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
            [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
            [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
            public void ShouldValidateTwoSum(int[] nums, int target, int[] expected)
            {
                var result = this.Sut.TwoSum(nums, target);

                result.Should().ContainInOrder(expected);
            }
        }
    }
}