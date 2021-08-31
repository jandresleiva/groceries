using System;
using Xunit;

namespace GroceriesTesting
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var a1 = 5;

            Assert.True(a1 == 5);
        }
    }
}
