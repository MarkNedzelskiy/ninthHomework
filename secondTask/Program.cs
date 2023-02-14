/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int CountNumbersRecursion( int m, int n)
{
    int summ = 0;
    if (m <= n)
    {
        summ += m + CountNumbersRecursion(m + 1, n);
    }
    return summ;
}

int numberM = GetNumber("Введите число M:");
int numberN = GetNumber("Введите число N:");
int summ = 0;
summ = CountNumbersRecursion(numberM, numberN);
Console.WriteLine(summ);