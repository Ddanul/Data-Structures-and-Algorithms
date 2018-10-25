using System;
using Xunit;
using MultiBracketValidation.Classes;
using MultiBracketValidation;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("{abc}", true)]
        [InlineData("{(abc}", false)]
        [InlineData("}{", false)]
        [InlineData("", true)]
        public void TestToCheckBalancedBrackets(string input, bool expected)
        {
            //Assert
            Assert.Equal(expected, Program.MultiBracketValidation(input));
        }
    }
}
