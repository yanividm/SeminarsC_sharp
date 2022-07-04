//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.



/*
int [] NewArray()
{
    int size;
    
    Console.WriteLine("Input array size");
    size = Convert.ToInt32(Console.ReadLine());

    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write(array[i] + " ");
    }
    return array;
}

int countEvenNum(int [] newarray)
{
    int count = 0;
    int [] array = newarray;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0 )
            {
             count++;
            }
        }
        if (count == 0 )
        {
            Console.WriteLine("No even num in array");
        }
    return count;
} 

int [] newarray = NewArray();
countEvenNum(newarray);
Console.WriteLine("the amount of even num is " + countEvenNum (newarray));

*/






//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.


/*

int [] createArray()
{
    int size;

    Console.WriteLine("Enter array size, please");
    size = Convert.ToInt32(Console.ReadLine());
    int [] array = new int [size]; 
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100);
        Console.Write(array[i] + " ");
    }
    return array;
} 
int sumNum (int [] secondArray)
{
    int sum = 0;
    int [] array = secondArray;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + array [i];
        }
    }
    return sum;
}

int [] secondArray = createArray();
sumNum (secondArray);
Console.WriteLine("the sum of non even index is " + sumNum(secondArray)); */

//Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.


/*
double [] arrayRealNum ()
{
    int size;
    Console.WriteLine ("Enter, please, array size");
    size = Convert.ToInt32(Console.ReadLine());
    double [] array = new double [size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*100;
        Console.Write(array[i] + " ");
    }
    return array ;
}
double findMax ( double [] thirdArray )
{
    double [] array = thirdArray;
    int i = 0;
    double max = array [i];
    for ( i = 0; i < array.Length; i++)
    {
        if (array [i] > max )
        {
            max = array [i];
        }
    }
    return max;
}
double findMin (double [] thirdArray)
{
    double [] array = thirdArray;
    int i = 0;
    double min = array [i];
    for ( i = 0; i < array.Length; i++)
    {
        if (array [i] < min )
        {
            min = array [i];
        }
    }
    return min;
}
double Subtraction (double max, double min)
{
    double sum = max + min;
    return sum;
} 

double [] thirdArray = arrayRealNum();
double max = findMax(thirdArray);
double min = findMin(thirdArray);
Console.WriteLine(Subtraction(max,min));

/*
