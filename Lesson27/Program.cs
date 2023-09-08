using Lesson27;
Animal firstAnimal = new Animal("Петя", "Слон", 5, 10, "Тропики");
string food = firstAnimal._food;
string title = firstAnimal.Title;
food = firstAnimal.GetFoodType(title, food);
firstAnimal.DoEat(food);
firstAnimal.DoVoice();
firstAnimal.DoGame();

Console.WriteLine();

Animal secAnimal = new Animal("Симба", "Пингвин", 1, 10, "Тундра");
title = secAnimal.Title;
food = secAnimal.GetFoodType(title, food);
secAnimal.DoEat(food);
secAnimal.DoVoice();
secAnimal.DoGame();

Console.WriteLine();

Animal thirdAnimal = new Animal("Матильда", "Тигр", 20, 10, "Пустыня");
title = thirdAnimal.Title;
food = thirdAnimal.GetFoodType(title, food);
thirdAnimal.DoEat(food);
thirdAnimal.DoVoice();
thirdAnimal.DoGame();