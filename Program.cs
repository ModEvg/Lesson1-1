// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.Write($"Введите число N: \n");
int N = int.Parse(Console.ReadLine());
int index;
index = 1;
Console.Write($"Все чётные числа от 1 до {N}: \n");
while (index <= N)
    {if (index%2 == 0)
    { Console.Write($" {index} ");}
    index = index + 1;}