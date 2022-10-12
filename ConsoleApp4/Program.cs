//Коваленок, 22-ИСП-2/2, 5.83
Console.WriteLine("Введите вещественное число: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int n = int.Parse(Console.ReadLine());
double p = 1;
for (int i = 1; i <= n; i++)
{
    p *= a;
}
Console.WriteLine($"{p:F2}"); 