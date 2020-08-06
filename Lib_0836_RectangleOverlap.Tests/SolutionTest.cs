using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using NUnit.Framework;

namespace Lib_0836_RectangleOverlap.Tests
{

    [TestFixture]
    public class SolutionTest
    {


        
        [Test, TestCaseSource(typeof(TestDataClass),nameof(TestDataClass.IsRectangleOverlapTestCases))]
        public bool IsRectangleOverlapTest(Rectangle r1, Rectangle r2)
        {
            return r1.IsOverlap(r2);
        }
        [Test, TestCaseSource(typeof(TestDataClass), nameof(TestDataClass.AddTestCase))]
        public int AddTest(int a,int b)
        {

            return a + b;
        }

      
    }

    public class TestDataClass
    {
        public static IEnumerable IsRectangleOverlapTestCases
        {
            get
            {
                yield return new TestCaseData(
                        new Rectangle(0, 0, 2, 2),
                        new Rectangle(1, 1, 3, 3)
                       ).Returns(true)
                    .SetName("Right top1")
                    .SetDescription("Leetcode test case1");
                yield return new TestCaseData(
                        new Rectangle(0, 0, 1, 1),
                        new Rectangle(1, 0, 2, 1)
                        ).Returns(false)
                    .SetName("Right top2")
                    .SetDescription("Leetcode test case2");
                yield return new TestCaseData(
                        new Rectangle(1, 1, 3, 3),
                        new Rectangle(0, 0, 2, 2))
                    .Returns(true)
                    .SetName("Right top Reverse3")
                    .SetDescription("Leetcode test case3");
                yield return new TestCaseData(
                        new Rectangle(1, 0, 2, 1),
                        new Rectangle(0, 0, 1, 1))
                    .Returns(false)
                    .SetName("Right top Reverse4")
                    .SetDescription("Leetcode test case4");

              
            }
        }

        public static IEnumerable AddTestCase
        {
            get
            {
                yield return new TestCaseData(
                       1,1)
                    .Returns(2)
                    .SetName("1+1=2")
                    .SetDescription("1111");
                yield return new TestCaseData(
                        5, 5)
                    .Returns(10)
                    .SetName("5+5=10")
                    .SetDescription("1111");

            }
        }
    }

   // public static IEnu
}