// ЗАДАЧА 41. Пользователь вводит с клавиатуры М чисел. Посчитать сколько чисел больше 0 ввел пользователь.

/*
int countPositiveNum(int [] array)
{
    int count = 0;
    int m = array.Length;
    for (int i = 0; i < m; i++)
    {
        if (array[i] > 0)
        {
        count++;
        }
        else
        {
        count = count + 0;    
        }
    }
    return count;
}

int [] NewArray = {-1, -2, -3, -4}; 
Console.WriteLine(countPositiveNum (NewArray)); */


// ЗАДАЧА 45. Программа, которая создает копию заданного массива с помощью поэлементного копирования

int [] arrayCopy (int [] array)
{
    int size = array.Length;
    int [] NewArray = new int [size];
    for (int i = 0; i < size; i++)
    {
      NewArray [i] = array [i];
      Console.Write(NewArray[i] + " ");
    }
    return NewArray;
}
int [] array = {6,5,3,1,2};
arrayCopy (array);
