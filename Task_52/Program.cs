//Задача 52.Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

 int countRows = 3;
 int countColumns = 4;

int[,] GetMatrix()
{
    int[,] matrix = new int[countRows, countColumns];
    Random rnd = new();
    
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

double[] GetAverange(int[,] matrix)
{
    double sum = 0;
    double[] results = new double[countColumns];

    for(int i = 0; i < countColumns; i++)
    {
      sum = 0;
        for( int j = 0; j < countRows; j++)
        {
            int elem = matrix[j, i];
            sum += elem;
            results[i] = Math.Round((sum / countRows), 1);
        }
    }

    return results;
}

void PrintMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0) Console.Write("[");
            if(j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, ");
            else Console.Write($"{array[i, j],3} ]");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix();
PrintMatrix(matrix);
Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write($"{GetAverange(matrix)[i]}  ");
    }

