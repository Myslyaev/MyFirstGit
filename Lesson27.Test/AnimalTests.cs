using Lesson27;
namespace Lesson27.Test
{
    public class AnimalTests
    {
        [TestCase("����", "", "����")]
        [TestCase("�������", "", "����, ����")]
        [TestCase("����", "", "����")]
        public void GetFoodTypeTest (string title, string food, string expected) 
        {
            string actual = Animal.GetFoodType(title, food);
            Assert.AreEqual(expected, actual);
        }
    }
}