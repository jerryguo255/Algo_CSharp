using Lib_0367_ValidPerfectSquare;
using Xunit;

namespace Algo_CSharp.Tests
{
    public class Lib_0367_ValidPerfectSquareTests
    {
        private readonly Solution _solution = new Solution();


        #region IsPerfectSquare Test

       
        [Theory]
        [InlineData(1), InlineData(4)]
        [InlineData(9)]
        [InlineData(16)]
        [InlineData(25)]
        [InlineData(36)]
        [InlineData(49)]
        [InlineData(64)]
        [InlineData(81)]
        [InlineData(100)]
        [InlineData(121)]
        [InlineData(144)]
        [InlineData(169)]
        [InlineData(196)]
        [InlineData(225)]
        [InlineData(30_261_001)]
        [InlineData(559_511_716)]
        public void IsPerfectSquareTest(int num)
        {
            Assert.True(_solution.IsPerfectSquare(num));
        }

        #endregion


        #region IsNotPerfectSquareTest

        [Theory]
        [InlineData(14)]
        [InlineData(43)]
        [InlineData(66)]
        [InlineData(67)]
        [InlineData(68)]
        [InlineData(2_000_105_819)]
        public void IsNotPerfectSquareTest(int num)
        {
            Assert.False(_solution.IsPerfectSquare(num));
        }

        #endregion



        //[Fact(DisplayName = "OtherIgnoredTask", Skip = "Todo task")]
        //public void OtherIgnoredTask()
        //{
        //    //todo:write test case
        //    //Hack: s
        //}
    }
}
