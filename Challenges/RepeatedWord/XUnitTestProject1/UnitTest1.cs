using System;
using Xunit;
using RepeatedWord;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("This is a sentence and is also a test", "is")]
        [InlineData("The quick red fox jumped over the lazy brown dog", "the")]
        [InlineData("This sentence has no repeated words", "No Repeated Words.")]
        public void TestToReturnVariousWordsIfAny(string value, string expected)
        {
            //Assert
            Assert.Equal(expected, Program.RepeatedWord(value));

        }
    }
}
