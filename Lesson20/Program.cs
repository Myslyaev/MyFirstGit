string number;
Console.WriteLine("Введите количество сотрудников");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] rating = new int[quantity];
int i = 0;
Console.WriteLine("Введите рейтинг сотрудника по одному, в конце напишите слово: конец");
while ((number = Console.ReadLine()) != "конец")
{
    rating[i++] = Convert.ToInt32(number);
}
int max = rating[0];
for (int n = 1; n < rating.Length; n++)
{
    if (max < rating[n])
    {
        max = rating[n];
    }
}
Console.WriteLine($"Самый высокий рейтинг: {max}");