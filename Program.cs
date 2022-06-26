// See https://aka.ms/new-console-template for more information

// Задача 2. Напишите программу, которая на вход принимает два числа и выдает, 
// какое число большее, а какое меньшее.

Console.WriteLine("Нахождение большего и меньшего числа");
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine(numberA + " - большее число, " + numberB + " - меньшее число");
}   
else
{
    Console.WriteLine(numberA + " - меньшее число, " + numberB + " - большее число");
}


Console.WriteLine();
// Задача 4. Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное их этих чисел.
Console.WriteLine("Нахождение макcимального числа из трех");
Console.WriteLine("Введите первое число");
int numberC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberD = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberE = Convert.ToInt32(Console.ReadLine());
int max = numberC;
if (numberD > max) max = numberD;
if (numberE > max) max = numberE;

Console.WriteLine(max + " - максимальное число из трех чисел");


Console.WriteLine();
// Задача 6. Напишите программу, которая на вход принимает число
// и выдаёт является ли число четным.

Console.WriteLine("Проверка числа на четность");
Console.WriteLine("Введите число");
int numberX = Convert.ToInt32(Console.ReadLine());
if (numberX % 2 == 0)
{
    Console.WriteLine(numberX + " - число является четным");
}
else
{
    Console.WriteLine(numberX + " - число является нечетным");
}

Console.WriteLine();
// Задача 8. Напишите программу, которая на вход принимает число (N )
// и на выходе показывает все четные числа от 1 до N.

Console.WriteLine("Вывести все четные числа до числа N");
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int number = 1;

while (N >= number)
{
if (number % 2 == 0)
Console.Write(number + "  ");
number = number + 1;
}