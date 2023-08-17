Console.WriteLine("Введите количество сотрудников");
int employeesCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите рейтинг сотрудника по одному, в конце напишите слово: конец");

int i = 0;
int[] ratingArr = new int[employeesCount];
string rating;
while ((rating = Console.ReadLine()) != "конец")
{
    ratingArr[i++] = Convert.ToInt32(rating);
}

int max = ratingArr[0];
for (i = 1; i < ratingArr.Length; i++)
{
    if (max < ratingArr[i])
    {
        max = ratingArr[i];
    }
}

Console.WriteLine($"Самый высокий рейтинг: {max}");