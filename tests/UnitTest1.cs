using System;
using Xunit;
using src;

namespace tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestSum()
        {
            Console.WriteLine("running test");
            src.Sum sum = new src.Sum();
            int val = sum.SumTwo(1,2);

            Assert.Equal(3, val);
        }

        [Fact]
        public void TestGenerator()
        {
            src.Sum item = new src.Sum();
            string taskName = item.Generate();

            Assert.Equal("Copy", taskName);
        }
    }
}
