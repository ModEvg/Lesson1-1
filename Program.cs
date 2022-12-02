// Программа, которая на вход принимает три числа и выдает, какое число максимальное
Console.Write($"Введите число a: \n");
int a = int.Parse(Console.ReadLine());
Console.Write($"Введите число b: \n");
int b = int.Parse(Console.ReadLine());
Console.Write($"Введите число c: \n");
int c = int.Parse(Console.ReadLine());

if (a>b & a>c)
    { Console.Write($"Число {a} максимальное");}
else
    if (b>c) 
    {Console.Write($"Число {b} максимальное");}
    else   {Console.Write($"Число {c} максимальное");}
