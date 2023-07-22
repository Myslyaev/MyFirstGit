using Lesson17;
namespace Lesson17.Test
{
    public class BankTests
    {
        [TestCase(1200, 3)]
        [TestCase(0, 0)]
        [TestCase(-1000, 0)]
        [TestCase(1266, 3)]
        public void GetBanknotesQuantityTest(int money, int expected)
        {
            int actual = Bank.GetBanknotesQuantity(money);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1000, 2, 10, 1210)]
        [TestCase(1000, 0, 10, 0)]
        [TestCase(0, 2, 10, 0)]
        [TestCase(1000, 2, 0, 1000)]
        [TestCase(-1000, 2, 10, 0)]
        [TestCase(1000, -2, 10, 0)]
        [TestCase(1000, 2, -10, 0)]

        public void GetDepositPercents(int dep, int year, int perc, int expected)
        {
            int actual = Bank.GetDepositPercents(dep, year, perc);
            Assert.AreEqual(expected, actual);
        }
    }
}