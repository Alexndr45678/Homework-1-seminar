// По заданным двум числам проверять является ли число "a" квадратом числа "b".
Console.WriteLine("Введите число: ");
double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());

if (b == a * a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}