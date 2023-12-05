// Задача 3: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.

Console.Write("Введите размер строки ");
int nX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер строки ");
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

int Result(int[,] arrRes)
{
    int result = 0;
    int temp = int.MaxValue;
    for (int i = 0; i < arrRes.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arrRes.GetLength(1); j++)
        {
            sum += arrRes[i, j];
        }
        if (sum < temp)
        {
            temp = sum;
            result = i;
        }
    }
    return result;
}

int[,] arr = AddMass(nX, nY, min, max);
PrintMass(arr);
Console.WriteLine(Result(arr));