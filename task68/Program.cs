// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 9

int Akkerman(int numM, int numN)
{
    if (numM == 0)
    {
        return numN + 1;
    }
    else if (numM != 0 && numN == 0)
    {
        return Akkerman(numM - 1, 1);
    }
    else
    {
        return Akkerman(numM - 1, Akkerman(numM, numN - 1));
    }
}

int m = 2;
int n = 3;
System.Console.WriteLine(Akkerman(m, n));



