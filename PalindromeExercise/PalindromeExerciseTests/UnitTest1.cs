using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("deed", true)]
        [InlineData("rotor", true)]
        [InlineData("mom", true)]
        [InlineData("level", true)]
        [InlineData("civic",true)]
        [InlineData("racecar", true)]

        public void IsAPalindrome(string word, bool expected)
        {
            var wordSmith = new WordSmith();
            var actual = wordSmith.Test(word);
            Assert.Equal(expected, actual);


        }
    }
}
