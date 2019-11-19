using _3_UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleTest
{
    public class TriangleTestHelper
    {
        private int sideA;
        private int sideB;
        private int sideC;

        public TriangleTestHelper(int sideA, int sideB, int sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public bool IsTriangleValid()
        {
            return Triangle.IsValid(sideA, sideB, sideC);
        }
    }

    [TestClass]
    public class TriangleTest
    {

        [TestMethod]
        public void IsValid_AllSidesAreNegative_ReturnsFalse()
        {
            var triangleTester = new TriangleTestHelper(-1, -2, -3);

            var result = triangleTester.IsTriangleValid();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_OneOfSidesIsNegative_ReturnsFalse()
        {
            var triangleTesterWithNegativeA = new TriangleTestHelper(-1, 2, 3);
            var triangleTesterWithNegativeB = new TriangleTestHelper(1, -2, 3);
            var triangleTesterWithNegativeC = new TriangleTestHelper(1, 2, -3);

            var resultNegativeA = triangleTesterWithNegativeA.IsTriangleValid();
            var resultNegativeB = triangleTesterWithNegativeB.IsTriangleValid();
            var resultNegativeC = triangleTesterWithNegativeC.IsTriangleValid();

            Assert.IsFalse(resultNegativeA);
            Assert.IsFalse(resultNegativeB);
            Assert.IsFalse(resultNegativeC);
        }

        [TestMethod]
        public void IsValid_AllSidesEqualsZero_ReturnsFalse()
        {
            var triangleTester = new TriangleTestHelper(0, 0, 0);

            var result = triangleTester.IsTriangleValid();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_OneOfSidesEqualsZero_ReturnsFalse()
        {
            var triangleTesterWithZeroA = new TriangleTestHelper(0, 2, 3);
            var triangleTesterWithZeroB = new TriangleTestHelper(1, 0, 3);
            var triangleTesterWithZeroC = new TriangleTestHelper(1, 2, 0);

            var resultZeroA = triangleTesterWithZeroA.IsTriangleValid();
            var resultZeroB = triangleTesterWithZeroB.IsTriangleValid();
            var resultZeroeC = triangleTesterWithZeroC.IsTriangleValid();

            Assert.IsFalse(resultZeroA);
            Assert.IsFalse(resultZeroB);
            Assert.IsFalse(resultZeroeC);
        }

        [TestMethod]
        public void IsValid_OneSideGreaterThanSumOfOtherTwoSides_ReturnsFalse()
        {
            var triangleTester = new TriangleTestHelper(5, 6, 12);

            var result = triangleTester.IsTriangleValid();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_OneSideEqualsSumOfOtherTwoSides_ReturnsFalse()
        {
            var triangleTester = new TriangleTestHelper(5, 6, 11);

            var result = triangleTester.IsTriangleValid();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_EachSideLessThanSumOfTwoRest_ReturnsTrue()
        {
            var triangleTester = new TriangleTestHelper(5, 6, 7);

            var result = triangleTester.IsTriangleValid();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValid_AEqualsThreeBEqualFourCEqualsFive_ReturnsTrue()
        {
            var triangleTester = new TriangleTestHelper(3, 4, 5);

            var result = triangleTester.IsTriangleValid();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsValid_AEqualsZeroBEqualFourCEqualsFive_ReturnsFalse()
        {
            var triangleTester = new TriangleTestHelper(0, 4, 5);

            var result = triangleTester.IsTriangleValid();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsValid_AEqualsMinusOneBEqualFourCEqualsFive_ReturnsFalse()
        {
            var triangleTester = new TriangleTestHelper(-1, 4, 5);

            var result = triangleTester.IsTriangleValid();

            Assert.IsFalse(result);
        }
    }
}
