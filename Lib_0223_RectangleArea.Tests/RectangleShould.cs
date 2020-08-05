using Xunit;

namespace Lib_0223_RectangleArea.Tests
{
    public class RectangleShould
    {

        [Theory]
        [InlineData(0, 0, 3, 2, 6)]
        [InlineData(0, 0, 13245, 21545, 285363525)]
        [InlineData(-3, 0, 3, 4, 24)]
        [InlineData(0, -1, 9, 2, 27)]
        [InlineData(0, 0, 0, 0, 0)]
        [InlineData(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue, 0)]


        //[ClassData(typeof(ComputeRectangleAreaData))]
        public void ComputeRectangleArea_Correct(int leftBottomX, int leftBottomY, int rightTopX, int rightTopY, int exceptedValue)
        {
            var r = new Rectangle(leftBottomX, leftBottomY, rightTopX, rightTopY);

            Assert.Equal(exceptedValue, r.Area);
        }
    }
}