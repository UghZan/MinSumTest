using MinSumTest.Main;
namespace MinSumTest.UnitTests
{
    [TestClass]
    public sealed class MinSum
    {
        [TestMethod]
        public void BasicRandomTest()
        {
            var testArray = MinSumCalc.GenerateRandomValues(100, -10, 10);
            int calcMin1 = 0, calcMin2 = 0;
            int compRes = MinSumCalc.LINQ_CalculateSum(testArray, ref calcMin1, ref calcMin2);
            int res = MinSumCalc.CalculateSum(testArray, ref calcMin1, ref calcMin2);
            Assert.AreEqual(compRes, res);
        }

        [TestMethod]
        public void StressRandomTest()
        {
            for (int i = 0; i < 10000; i++)
            {
                var testArray = MinSumCalc.GenerateRandomValues(10000, -1000000, 1000000);
                int _calcMin1 = 0, _calcMin2 = 0;
                int compRes = MinSumCalc.LINQ_CalculateSum(testArray, ref _calcMin1, ref _calcMin2);
                int calcMin1 = 0, calcMin2 = 0;
                int res = MinSumCalc.CalculateSum(testArray, ref calcMin1, ref calcMin2);
                Assert.AreEqual(compRes, res);
            }
        }

        [TestMethod]
        public void EmptyArrayTest()
        {
            var testArray = new int[] { };
            int calcMin1 = 0, calcMin2 = 0;
            int compRes = MinSumCalc.LINQ_CalculateSum(testArray, ref calcMin1, ref calcMin2);
            int res = MinSumCalc.CalculateSum(testArray, ref calcMin1, ref calcMin2);
            Assert.AreEqual(compRes, res);
        }

        [TestMethod]
        public void TwoValuesTest()
        {
            var testArray = MinSumCalc.GenerateRandomValues(2, -10000, 10000);
            int calcMin1 = 0, calcMin2 = 0;
            int compRes = MinSumCalc.LINQ_CalculateSum(testArray, ref calcMin1, ref calcMin2);
            int res = MinSumCalc.CalculateSum(testArray, ref calcMin1, ref calcMin2);
            Assert.AreEqual(compRes, res);
        }

        [TestMethod]
        public void SingleZeroTest()
        {
            var testArray = new int[] { 0 };
            int calcMin1 = 0, calcMin2 = 0;
            int compRes = MinSumCalc.LINQ_CalculateSum(testArray, ref calcMin1, ref calcMin2);
            int res = MinSumCalc.CalculateSum(testArray, ref calcMin1, ref calcMin2);
            Assert.AreEqual(compRes, res);
        }

        [TestMethod]
        public void PremadeArrayTest()
        {
            var testArray = new int[] { 1, 3, 2, 4, -1 };
            int calcMin1 = 0, calcMin2 = 0;
            int compRes = MinSumCalc.LINQ_CalculateSum(testArray, ref calcMin1, ref calcMin2);
            int res = MinSumCalc.CalculateSum(testArray, ref calcMin1, ref calcMin2);
            Assert.AreEqual(compRes, res);
        }

        [TestMethod]
        public void PremadeTrickyCaseTest()
        {
            var testArray = new int[] { -3, -2, -1 };
            int calcMin1 = 0, calcMin2 = 0;
            int compRes = MinSumCalc.LINQ_CalculateSum(testArray, ref calcMin1, ref calcMin2);
            int res = MinSumCalc.CalculateSum(testArray, ref calcMin1, ref calcMin2);
            Assert.AreEqual(compRes, res);
        }

        [TestMethod]
        public void PremadeTrickyCase2Test()
        {
            var testArray = new int[] { -1, -3, -2, -1, -6 };
            int calcMin1 = 0, calcMin2 = 0;
            int compRes = MinSumCalc.LINQ_CalculateSum(testArray, ref calcMin1, ref calcMin2);
            int res = MinSumCalc.CalculateSum(testArray, ref calcMin1, ref calcMin2);
            Assert.AreEqual(compRes, res);
        }

        [TestMethod]
        public void ThousandZerosTest()
        {
            var testArray = MinSumCalc.GenerateRandomValues(1000,0,0);
            int calcMin1 = 0, calcMin2 = 0;
            int compRes = MinSumCalc.LINQ_CalculateSum(testArray, ref calcMin1, ref calcMin2);
            int res = MinSumCalc.CalculateSum(testArray, ref calcMin1, ref calcMin2);
            Assert.AreEqual(compRes, res);
        }
    }
}
