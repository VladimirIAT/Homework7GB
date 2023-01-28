// Задача 52. Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел : ");
string[] parameters = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);

double[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));

PrintMatrixArray(array);
WriteLine();
PrintArray(Average(array));

double[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue) 
{
    Random rnd = new Random();
    double[,] resultArray = new double[rows, columns];
    for (int i=0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = rnd.Next(minValue,maxValue);
        }
    }
    return resultArray;
}

double[] Average(double[,] inArray) 
{
    double[] averageArray = new double[inArray.GetLength(1)];
    
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            average = inArray[i, j] + average;
        }
        averageArray[j] = average / inArray.GetLength(0);
    }
    return averageArray;
}

void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j],3} ");
        }
        WriteLine();
    }
}

void PrintArray(double[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Write($"{inArray[i],3} ");
    }
}