//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:

//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7->такого числа в массиве нет

 int CountRows = 3;
 int CountColumns = 4;

int[,] GetMatrix()
{
    int[,] matrix = new int[CountRows, CountColumns];
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

void GetElement(int[,] matrix)
{
    Console.WriteLine("Напишите позицию элемента в строке матрицы:");
   int firstNum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Напишите позицию элемента в столбце матрицы:");
    int secondNum = Convert.ToInt32(Console.ReadLine());   
   
    if(firstNum > matrix.GetLength(0)  || firstNum < 0 ||
	   secondNum > matrix.GetLength(1) || secondNum < 0 )

	{
		Console.WriteLine();
		Console.WriteLine($"{firstNum}, {secondNum} -> такого числа в массиве нет");
	}
	else
	{
		Console.WriteLine($"Заданный элемент матрицы  {matrix[firstNum, secondNum]}");
	}
	
}

int[,] matrix = GetMatrix();
PrintMatrix(matrix);
Console.WriteLine();
GetElement(matrix);
