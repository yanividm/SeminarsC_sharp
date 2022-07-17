//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] createNewArray (int m, int n)
{
    double [,] newArray = new double [m,n];
    
    for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                {
                    newArray [i,j] = new Random().NextDouble()*1000;
                    Console.Write(newArray[i,j]+ " ");
                }
                Console.WriteLine();
        }
    return newArray;
}

Console.WriteLine("Enter, please, amout of rows");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter, please, amout of columns");
int y = Convert.ToInt32(Console.ReadLine());


double [,] array = createNewArray(x, y);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.



int [,] createNewArray (int m, int n)
{
    int [,] newArray = new int [m,n];
    
    for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
                {
                    newArray [i,j] = new Random().Next(1,10);
                    Console.Write(newArray[i,j]+ " ");
                }
                Console.WriteLine();
        }
    return newArray;
}

Console.WriteLine("Enter, please, amout of rows");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter, please, amout of columns");
int y = Convert.ToInt32(Console.ReadLine());


int [,] array = createNewArray(x, y);

Console.WriteLine("Enter, please, row of the element");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter, please, column of the element");
int col = Convert.ToInt32(Console.ReadLine());

if (row < x && col <y)
    {
        Console.WriteLine("The element exist and this is " + array [row, col]);
    }
    else
    {
        Console.WriteLine(" the element is not in the boundaries of array");
    }

