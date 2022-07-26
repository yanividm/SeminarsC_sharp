//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int sumIntNum (int M, int N)
{
    if (M <= N)
    {
        return M + sumIntNum (M +1 , N);
    }
    return 0;
}

int m = 1;
int n = 15; 
Console.WriteLine(sumIntNum(m,n));

*/
//Напишите программу, которая будет принимать на вход число 
//и возвращать кол-во его цифр.
// с= a % b -  остаток от деления 5 % 2 = 1, 5 / 2 =2  
// 1234 / 10 -> 123 % 10 -> 3
// 1234 %10 -> 4
// 1234 % 100 -> 34
// 1234 / 100 -> 12


int countOfNum(int num, int count)
{
    if (num < 10) 
        return count + 1;
        return countOfNum(num / 10, count +1);
     
}

int num = 4582;
int count = 0;
Console.WriteLine (countOfNum(num, count));