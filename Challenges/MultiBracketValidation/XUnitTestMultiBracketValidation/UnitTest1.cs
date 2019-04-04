using System;
using Xunit;
using MultiBracketValidation;

namespace XUnitTestMultiBracketValidation
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("[{The {quick([ ])brown} fox}]")]
        [InlineData("[The {quick([{ }])brown} fox]")]
        [InlineData("[{The {quick([{ }])brown} fox}]")]
        [InlineData("{The {quick([{ }])brown} fox}")]
        [InlineData("{}[]()()[]{}")]
        [InlineData("{}[](())()[[]]{{}}")]
        [InlineData("nothing but text")]
        [InlineData("(){}[[]]")]
        [InlineData("()[[Extra Characters]]")]
        [InlineData("{}{Code}(())")]
        [InlineData("{}(){}")]
        [InlineData("{}")]
        public void HappyTest(string a)
        {
            bool result = Program.MultiBracketValidationMethod(a);
            Assert.True(result);
        }

        [Theory]
        [InlineData("{(})")]
        [InlineData("[({}]")]
        [InlineData("(](")]
        [InlineData("[[[[[[[[[[[[[[[[[[")]
        [InlineData("]]]]]]]]]]]]]]]]]]")]
        [InlineData("]][[[[[[[[[]]]]]]]]]")]
        [InlineData("]]]][]{}{}[[[[[]]")]

        public void SadTest(string a)
        {
            bool result = Program.MultiBracketValidationMethod(a);
            Assert.False(result);
        }
    }
}
