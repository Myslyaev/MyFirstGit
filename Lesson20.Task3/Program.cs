string number;
Console.WriteLine("Введите количество сотрудников");
int quantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите план продаж");
int plan = Convert.ToInt32(Console.ReadLine());
int[] rating = new int[quantity];
int i = 0;
int lessThanPlan =0;
Console.WriteLine("Введите сумму продаж каждого сотрудника по одному, в конце напишите слово: конец");
while ((number = Console.ReadLine()) != "конец")
{
    rating[i++] = Convert.ToInt32(number);
}
for (int n = 0; n < rating.Length; n++)
{
    if (rating[n] < plan)
    {
        lessThanPlan++;
    }
}
Console.WriteLine($"Количество сотрудников не выполнивших план: {lessThanPlan}");