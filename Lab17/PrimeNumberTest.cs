using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lab17
{// 2 3 5 7 11
    public class PrimeNumberTest
    {
        [Fact]
        public void Test2()
        {
            int actual = PrimeNumberFinder.GetPrimeNumberAtPosition(5);
            int expected = 11;

            Assert.Equal(expected, actual);
        }
    }
}
