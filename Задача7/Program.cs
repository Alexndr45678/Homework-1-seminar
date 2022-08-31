// Показать вторую цифру трехзначного числа.

Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(a);
Console.WriteLine(stringNumber[1]);