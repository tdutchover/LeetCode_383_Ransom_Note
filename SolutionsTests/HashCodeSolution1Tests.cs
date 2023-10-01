using Solutions;

namespace SolutionsTests
{
    public class HashCodeSolution1Tests
    {
        [Theory]
        [InlineData("abc", "ab", false)]    // Exit early
        [InlineData("cab", "bac", true)]    // not same order
        [InlineData("a", "b", false)]
        [InlineData("aa", "ab", false)]
        [InlineData("aa", "aab", true)]     // Ransom is bigger than magazine
        public void Test1(string ransomNote, string magazine, bool expected)
        {
            HashCodeSolution1 sut = new();

            bool actual = sut.CanConstruct(ransomNote, magazine);

            Assert.Equal(expected, actual);
        }
    }
}