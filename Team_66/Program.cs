// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumber (int start, int end)
{
    if (start==end)
    {
        return start;
    }
    if (start>end)
    {
        Console.WriteLine("Числа введены некорректно");
        return(0);
    }
    return (start+SumNumber(start+1,end));
}
Console.WriteLine(SumNumber(m,n));

