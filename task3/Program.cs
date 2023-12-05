// Задача 4*(не обязательная): Задайте двумерный массив
// из целых чисел. Напишите программу, которая удалит
// строку и столбец, на пересечении которых расположен
// наименьший элемент массива. Под удалением
// понимается создание нового двумерного массива без
// строки и столбца

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

int[] FindMinRowCol(int[,] arrayMin)
{
    int rowN = 0;
    int colN = 0;
    for (int i = 0; i < arrayMin.GetLength(0); i++)
    {
        for (int j = 0; j < arrayMin.GetLength(1); j++)
        {
            if (arrayMin[i, j] < arrayMin[rowN, colN])
            {
                rowN = i;
                colN = j;
            }
        }
    }
    return new int[] { rowN, colN };
}

int[,] RowColDel(int[,] arrDel, int rowDel, int colDel)
{
    int[,] arrTemp = new int[arrDel.GetLength(0) - 1, arrDel.GetLength(1) - 1];

    int row = 0;
    for (int i = 0; i < arrTemp.GetLength(0); i++)
    {
        if (i == rowDel) row++;
        int col = 0;
        for (int j = 0; j < arrTemp.GetLength(1); j++)
        {
            if (j == colDel) col++;
            arrTemp[i, j] = arrDel[row, col];
            col++;
        }
        row++;
    }
    return arrTemp;
}


int[,] arr = AddMass(nX, nY, min, max);
PrintMass(arr);
Console.WriteLine();

int[] coordinat = FindMinRowCol(arr);
Console.WriteLine($"Наименьшее значение {arr[coordinat[0], coordinat[1]]} по адрессу {coordinat[0]}, {coordinat[1]}.");
Console.WriteLine();

int[,] resArr = RowColDel(arr,coordinat[0], coordinat[1]);
PrintMass(resArr);