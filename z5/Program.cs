﻿Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int third = int.Parse(Console.ReadLine()!);
int max = int.MinValue;
if (first > max) max = first;
if (second > max) max = second;
if (third > max) max = third;
Console.WriteLine($"Максимальное число: {max}");