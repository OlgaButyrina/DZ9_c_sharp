// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumMtoN(int numM, int numN, int sum)
{
    if (numN <= numM)
    {
        return sum;
    }
        sum += numN;
        return SumMtoN(numM, numN - 1, sum);
}

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
if (m > n)
{
    int change = m;
    m = n;
    n = change;
}
System.Console.WriteLine(SumMtoN(m, n, m));


