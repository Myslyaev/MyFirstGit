﻿using Lesson26;
Animal animal = new Animal();
animal.Name = "Петя";
animal.Age = 5;
animal.Title = "Слон";
animal.Biom = "Тропики";
animal.Area= 10;
animal.Food = "Рыба";
animal.Voice = "Ауф";
animal.DoEat();
animal.DoVoice();
animal.DoGame();

Console.WriteLine();
animal = new Animal();
animal.Name = "Симба";
animal.Age = 1;
animal.Title = "Пингвин";
animal.Biom = "Тундра";
animal.Area = 10;
animal.Food = "Рыба, мясо";
animal.Voice = "Хрю";
animal.DoEat();
animal.DoVoice();
animal.DoGame();

Console.WriteLine();
animal = new Animal();
animal.Name = "Матильда";
animal.Age = 20;
animal.Title = "Тигр";
animal.Biom = "Пустыня";
animal.Area = 10;
animal.Food = "Мясо, сено";
animal.Voice = "Рррр";
animal.DoEat();
animal.DoVoice();
animal.DoGame();