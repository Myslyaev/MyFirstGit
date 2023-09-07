using Lesson27;
namespace Lesson27.Test
{
    public class AnimalTests
    {
        [TestCase("Слон", "", "Рыба")]
        [TestCase("Пингвин", "", "Мясо, сено")]
        [TestCase("Тигр", "", "Мясо")]
        public void GetFoodTypeTest (string title, string food, string expected) 
        {
            string actual = Animal.GetFoodType(title, food);
            Assert.AreEqual(expected, actual);
        }
    }
}