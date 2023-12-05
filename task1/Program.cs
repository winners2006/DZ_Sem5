// Задача 2: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.

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

void Result(int[,] arrRes)
{
    int arrEnd = arrRes.GetLength(0);
    for(int i = 0; i < arrRes.GetLength(1); i++)
            {
                int tmp = arrRes[arrEnd-1, i];
                arrRes[arrEnd-1, i] = arrRes[0, i];
                arrRes[0, i] = tmp;
            }
}

int[,] arr = AddMass(nX, nY, min, max);
PrintMass(arr);
Console.WriteLine();

Result(arr);
PrintMass(arr);