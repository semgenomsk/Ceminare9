﻿// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMtoN(int m, int n)
{
    if (n < m)
    {
        return;
    }
    else
    {
        PrintMtoN(m, n - 1);
        Console.Write(n + " ");
    }
}

int M = ReadNumber("Введите M: ");
int N = ReadNumber("Введите N: ");

if(M<=N)PrintMtoN(M,N);
else Console.WriteLine("Mдолжно быть не больше N");