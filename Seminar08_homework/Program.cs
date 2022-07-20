//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
/*


int [,] compareandmove(int [,] array, int m , int n)
{
    int temp;
    int i = 0;
    int minj = 0;
    int min = array [i,minj];
       for (int j = 0; j < n; j++)
       {
        
         if (array[i,j] < min)
         {
            temp = array [i,j];
            array [i,j] = array [i,j+1];
            array [i,j+1] = temp;
         }
       
    }
    return array; 
}



int m = 4;
int n = 4;
int [,] newArray = createNewArray(m,n);


newArray = compareandmove(newArray, m, n);
Console.WriteLine();
showArray(newArray);

решение 



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
void showArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void compareandmove (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1)-1; x++)
            {
                if (array[i,x] > array [i,x+1])
                {
                    int temp = array[i,x +1];
                    array[i,x +1] = array[i,x];
                    array[i,x] = temp;
                }
            }
        }
    }
}
int m = 4;
int n = 4;
int [,] newArray = createNewArray(m,n);

Console.WriteLine();
compareandmove(newArray);
showArray(newArray);


*/
//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.


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
void showArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
/*
void findSumOfCollumn(int [,] array, int row, int col)
{
    int minsum = 0;
    int sum1 = 0;
    int sum2 = 0;
    int minRow = 0;
    for (int i = 0; i < row; i++)
    {
        sum2=0;
        for (int j = 0; j < col; j++)
        {
           sum2 += array [i,j];
            if (sum2 < sum1)
            {
            minsum = sum2;
            minRow = i;
            }   
        sum1 = sum2;   
    }     
    Console.WriteLine($"наименьшая сумма {minRow} строки =  {minsum} ");
    }
}*/
int sumRow(int [,] array, int row)
{
    int rowSum = array [row, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        rowSum += array [row,j];
    }   
    return rowSum;
}

int m = 4;
int n = 2;
int [,] newArray = createNewArray(m,n);

Console.WriteLine();


sumRow(newArray,0);
showArray(newArray);
//Задача 62. Заполните спирально массив 4 на 4.


