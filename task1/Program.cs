﻿//Задача 1
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N
//Использовать рекурсию, не использовать циклы.

void ShowNumbers (int m, int n)
{
    if (m > n)
        return;
    if (m < n +1)
    {
        Console.Write($"{m} "); 
        ShowNumbers (m+1, n);          
    }
}

ShowNumbers (2, 5);


