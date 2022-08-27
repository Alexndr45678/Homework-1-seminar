// Найти максимальное из трех чисел.

int a = 23565;
int b = 32236;
int c = 87532;
int max = a;
if (b > a) max = b;
if (c > max) max = c;
Console.WriteLine(max);