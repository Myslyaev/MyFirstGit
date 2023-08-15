using Lesson17;
namespace Lesson17.Test
{
    public class BankTests
    {
        [TestCase(1200, 3)]
        [TestCase(1266, 3)]
        public void GetBanknotesQuantityTest(int money, int expected)
        {
            int actual = Bank.GetBanknotesQuantity(money);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetBanknotesQuantityTest_WhenMoneyIsZero_ShouldArgumentException()
        {
            int money = 0;
            Assert.Throws<ArgumentException>(() => Bank.GetBanknotesQuantity(money));
        }

        [Test]
        public void GetBanknotesQuantityTest_WhenMoneyIsLessZero_ShouldArgumentException()
        {
            int money = -10;
            Assert.Throws<ArgumentException>(() => Bank.GetBanknotesQuantity(money));
        }

        [TestCase(1000, 2, 10, 1210)]
        [TestCase(1000, 0, 10, 0)]
        [TestCase(0, 2, 10, 0)]
        [TestCase(1000, 2, 0, 1000)]
        public void GetDepositPercents(int dep, int year, int perc, int expected)
        {
            int actual = Bank.GetDepositPercents(dep, year, perc);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetDepositPercents_WhenDepYearPercentIsLessZero_ShouldArgumentException()
        {
            int dep = -10;
            int year = -10;
            int perc = -10;

            Assert.Throws<ArgumentException>(() => Bank.GetDepositPercents(dep, year, perc));
        }
    }
}