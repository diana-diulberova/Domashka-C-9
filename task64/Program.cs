﻿/*
Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N 
от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""
*/

Console.Clear();

Console.WriteLine("Введите число M: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

string NumbersRec(int firstUserNumber, int secondUserNumber)
{
    if(firstUserNumber < secondUserNumber)
    { 
        return $"{secondUserNumber} " + NumbersRec(firstUserNumber, secondUserNumber - 1);
    }
    else
    { 
         return $"{firstUserNumber} ";
    }
}

Console.WriteLine(NumbersRec(firstUserNumber, secondUserNumber));