﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12


int SumNumbers(int n)
{
    int sum = 0;
    while (n > 0){
        sum = sum + n % 10;
        n /= 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"Сумма цифр = {SumNumbers(n)}");