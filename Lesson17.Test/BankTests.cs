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
    }
}