// Программа, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.Write($"Введите число a: \n");
int a = int.Parse(Console.ReadLine());
Console.Write($"Введите число b: \n");
int b = int.Parse(Console.ReadLine());

if (a>b) {
    Console.Write($"Число {a} наибольшее, число {b} наименьшее");}
else {
   Console.Write($"Число {b} наибольшее, число {a} наименьшее");}
