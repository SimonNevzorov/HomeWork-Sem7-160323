// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double [,] GetNewArray (int x, int y)
{
    double [,] array1 = new double [x,y];
    Random rand = new Random();
    for (int a =0; a < array1.GetLength(0);a++)
    {
        for (int b =0; b < array1.GetLength(1);b++)
        {
            array1 [a,b] = Math.Round((rand.NextDouble()*100),2);
            Console.Write(array1[a,b]+"\t");
        }
    Console.WriteLine();
    }
return array1;
}

int row = Prompt("Введите количество строк массива");
int column= Prompt("Введите количество столбцов массива");
GetNewArray(row,column);