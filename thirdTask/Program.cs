/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber (string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int CountAckermannFunction (int m, int n)
{
    
    if (m == 0) return n + 1;
    
    else if (m > 0 && n == 0) return CountAckermannFunction(m - 1, 1);
    
    else return CountAckermannFunction(m - 1, CountAckermannFunction(m , n - 1));
}

int numberM = GetNumber("Введите число M:");
int numberN = GetNumber("Введите число N:");
int ackermann = CountAckermannFunction(numberM, numberN);
Console.WriteLine(ackermann);
