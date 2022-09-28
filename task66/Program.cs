/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму чётных чисел натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18
*/

Console.Clear();

Console.WriteLine("Введите число M: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

if(firstUserNumber % 2 != 0)
{
    firstUserNumber++;
}

int NumbersRec(int firstUserNumber, int secondUserNumber)
{
    if(firstUserNumber <= secondUserNumber)
    { 
        return firstUserNumber + NumbersRec(firstUserNumber + 2, secondUserNumber);
    }
    else
    { 
         return 0;
    }
}

Console.WriteLine(NumbersRec(firstUserNumber, secondUserNumber));