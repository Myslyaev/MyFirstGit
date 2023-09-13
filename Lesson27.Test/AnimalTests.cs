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
            Animal someAnimal = new Animal("����", "����", 5, 10, "�������");
            string actual = someAnimal.GetFoodType(title, food);
            Assert.AreEqual(expected, actual);
        }
        public void GetFoodTypeTest_WhenTitleIsNotTrue_ShouldArgumentException()
        {
            Animal someAnimal = new Animal("����", "�����", 5, 10, "�������");
            string title = "";
            Assert.Throws<ArgumentException>(() => someAnimal.GetFoodType(title));
        }
    }
}