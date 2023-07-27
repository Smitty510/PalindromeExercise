using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("horse", false)]
        [InlineData("racecar", true)]
        [InlineData("Yo, Banana Boy", false)]
        [InlineData("tattarrattat", true)]
        public void IsAPalindromeTest1(string someWord, bool expected)
        {
            var instance = new WordSmith();

            var actual = instance.IsAPalindrome(someWord);

            Assert.Equal(expected, actual);
        }
    }
}
