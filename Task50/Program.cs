// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, 
// и возвращающий значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9
using static System.Console;
Clear();

Write("Введите размер матрицы и диапазон значений через пробел : ");
// string[] parameters = ReadLine()!.Split(" ",StringSplitOptions.RemoveEmptyEntries);
string[] parameters = ReadLine()!.Split(new string[]{" ", "#", ";", ","},StringSplitOptions.RemoveEmptyEntries);

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));

PrintMatrixArray(array);
WriteLine("Введите адрес элемента в двумерном массиве [i; j] через \";\" ");
string[] parameters2 = ReadLine()!.Split(new string[]{" ", "#", ";", ","},StringSplitOptions.RemoveEmptyEntries);

if (int.Parse(parameters2[0]) >  int.Parse(parameters[0]) | int.Parse(parameters2[1]) > int.Parse(parameters[1]))
{
    WriteLine("Такого элемента в массиве нет");
} else {
    Write(numerous(array, int.Parse(parameters2[0]), int.Parse(parameters2[1])));
}


int numerous(int[,] inArray, int a, int b) 
{
    int num = inArray[a,b];

    return num;
}

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue) 
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i=0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i,j] = rnd.Next(minValue,maxValue);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
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

