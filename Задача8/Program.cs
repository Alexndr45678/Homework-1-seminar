// удалить вторую цифру трехзначного числа.

int a = new Random().Next(100, 999);
Console.WriteLine(a);
string number = a.ToString();
Console.WriteLine(number.Remove(1, 1));