namespace LeetcodeSolutionsTest
{
    public class MergeAlternately1768
    {
        [Theory]
        [InlineData("abc", "pqr", "apbqcr")]
        [InlineData("ab", "pqrs", "apbqrs")]
        [InlineData("abcd", "pq", "apbqcd")]
        public void Test1(string word1, string word2, string expected)
        {
            var solution = new Solution();
            var result = solution.MergeAlternately1768(word1, word2);
            Assert.Equal(expected, result);
        }
    }
}