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
            Animal someAnimal = new Animal("Петя", "Слон", 5, 10, "Тропики");
            string actual = someAnimal.GetFoodType(title, food);
            Assert.AreEqual(expected, actual);
        }
        public void GetFoodTypeTest_WhenTitleIsNotTrue_ShouldArgumentException()
        {
            Animal someAnimal = new Animal("Петя", "Жираф", 5, 10, "Тропики");
            string title = "";
            Assert.Throws<ArgumentException>(() => someAnimal.GetFoodType(title));
        }
    }
}