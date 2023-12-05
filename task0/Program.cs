// Задача 1: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.


Console.Write("Введите размер строки ");
int nX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер столбца ");
int nY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] AddMass(int m, int n, int minN, int maxN)
{

    int[,] arrNew = new int[m, n];
    Random ran = new Random();
    for (int i = 0; i < arrNew.GetLength(0); i++)
    {
        for (int j = 0; j < arrNew.GetLength(1); j++)
        {
            arrNew[i, j] = ran.Next(minN, maxN);
        }
    }
    return arrNew;
}

void PrintMass(int[,] arrPrint)
{
    for (int i = 0; i < arrPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrPrint.GetLength(1); j++)
        {
            Console.Write($"{arrPrint[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindEl(int[,] arrayFind, int findX, int findY)
{
    int el = 0;
    for (int i = 0; i < arrayFind.GetLength(0); i++)
    {
        for (int j = 0; j < arrayFind.GetLength(1); j++)
        {
            if (arrayFind[i, j] == arrayFind[findX, findY])
            {
                el = arrayFind[i, j];
            }
        }
    }
    return el;
}

int[,] arr = AddMass(nX, nY, min, max);
PrintMass(arr);
Console.WriteLine();

Console.Write("Введите адрес строки ");
int numFindX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите адрес столбца ");
int numFindY = Convert.ToInt32(Console.ReadLine());
if (numFindX > nX - 1 || numFindY > nY - 1)
{
    Console.WriteLine("Введенное значение за границами массива!");
    Environment.Exit(0);
}

int result = FindEl(arr, numFindX, numFindY);
Console.WriteLine($"Значение элемента {result}");