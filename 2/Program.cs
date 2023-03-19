// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

int Prompt( string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GetNewArray (int m, int n)
{
    int [,] array1 = new int [m,n];
    for (int i =0; i <array1.GetLength(0);i++)
    {
        for (int j=0; j<array1.GetLength(1);j++)
        {
          array1[i,j] = new Random().Next(1,11);
          Console.Write(array1[i,j] + "\t");
        }
    Console.WriteLine();    
    }
return array1;
}

void FindElement (int [,] array1, int c, int d)
{ if (c < 0 | c > array1.GetLength(0)-1| d <0 | d > array1.GetLength(1)-1)
    { Console.WriteLine(" Таких строк и столбцов в данном массиве нет!");
    
    }
  else 
  {
    Console.WriteLine($"Искомый элемент = {array1[c,d]}" );
  }  
     
}




int a = Prompt("Введите количество строк");
int b = Prompt("Введите количество столбцов");

int [,] mass = GetNewArray(a,b);
Console.WriteLine();
int c = Prompt("Введите индекс строки искомого элемента ");
int d = Prompt("Введите индекс строки искомого элемента ");

FindElement(mass, c, d);

