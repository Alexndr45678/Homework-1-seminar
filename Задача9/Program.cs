// Выяснить, кратно ли число заданному, если нет, вывести остаток.

double a = 125;
double b = 30;
bool c = (a % b == 0);
Console.WriteLine(c);
Convert.ToInt64(c);
if (c == false)
{
    Console.WriteLine(a % b);
}