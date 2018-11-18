using System;
using UniqueCharacters;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Ilovecats", true)]
        [InlineData("IloceChickens", false)]
        [InlineData("Oops", false)]
        public void TestToCheckForUniqueCharacters(string phrase, bool expected)
        {
            //assert
            Assert.Equal(expected, Program.UniqueCharacters(phrase));

        }
    }
}
