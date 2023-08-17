Console.WriteLine("Введите количество сотрудников");
int employeesCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите план продаж");
int salesPlan = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите сумму продаж каждого сотрудника по одному, в конце напишите слово: конец");

int i = 0;
int lessThanPlan = 0;
int[] ratingArr = new int[employeesCount];
string salesSummary;
while ((salesSummary = Console.ReadLine()) != "конец")
{
    ratingArr[i++] = Convert.ToInt32(salesSummary);
}

for (i = 0; i < ratingArr.Length; i++)
{
    if (ratingArr[i] < salesPlan)
    {
        lessThanPlan++;
    }
}

Console.WriteLine($"Количество сотрудников не выполнивших план: {lessThanPlan}");