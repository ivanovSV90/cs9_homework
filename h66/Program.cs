// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sum = 0;
System.Console.WriteLine(AmountBetween(1, 15));

int AmountBetween(int n, int m)
{
    if (n > m)
    {        
        return sum;
    }
    sum += n;
    AmountBetween(n + 1, m);
    return sum;
}