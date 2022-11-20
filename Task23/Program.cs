﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = ReadInt("Введите число: ");

int count = 1;

Console.Write($"{number} -> ");

while (count < number)
{
    Console.Write($"{count*count*count}, ");
    count++;
}

Console.WriteLine(count*count*count);




int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}