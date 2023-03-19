// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int Prompt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetNewArray(int m, int n)
{
    int[,] array1 = new int[m, n];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            array1[i, j] = new Random().Next(1, 11);
            Console.Write(array1[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array1;
}

void SumColumn(int[,] array1, int row, int column)
{

    
        
        for (int j = 0; j < array1.GetLength(1); j++)
    { double sum = 0;
        for (int i=0; i < array1.GetLength(0);i++)
        {
            sum += array1[i,j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j} равно {Math.Round(sum / array1.GetLength(0),2)}");

    }
}

int a = Prompt("Введите количество строк массива");
int b = Prompt("Введите количество столбцов массива");
Console.WriteLine();
int[,] array = GetNewArray(a, b);
int column = b;
int row = a;
SumColumn(array, a,b);