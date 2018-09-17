using Algorithm.Implementation;
using System;
using Xunit;

namespace Algorithm.UnitTest
{
    public class DuplicateTest
    {
        [Fact]
        public void Main()
        {
            var arr = new int[] { 2, 3, 1, 0, 2, 5,3,1 };
            var result = new DuplicateNumbersInTheArray().ProblemSolve(arr);
        }
    }
}
