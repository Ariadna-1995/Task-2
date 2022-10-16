//Задача 4: Напишите программу, которая принимает на вход 3 числа и выдает максимальное из этих чисел
Console.Write("Введите 1-е число ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число ");
int num2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-е число ");
int num3 = int.Parse(Console.ReadLine()!);
int max = num1; 
if(num1>max)
{
    max = num1;
}
if(num2>max)
{
    max = num2;
}
if(num3>max)
{
    max = num3;
}
Console.Write($"{max} - максимальное число");