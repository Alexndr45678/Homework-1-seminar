// Найти третью цифру числа или сообщить, что её нет

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int b = (int)Math.Log10(a)-2;
Console.WriteLine(b < 0 ? "Третьей цифры нет." : (a % (int)Math.Pow(10, b + 1) / (int)Math.Pow(10, b)).ToString());