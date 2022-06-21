//task 10


/* 
Либо через запрос числа у пользователя 
int num3;
Console.WriteLine("Enter three-digit number ");
num3 = Convert.ToInt32(Console.ReadLine());*/
/*
int secondNum(int num)
{
    int num2 = num % 100;
    int resultNum = num2 / 10;
    return resultNum;
}
// Либо через рандом 
int num = new Random().Next(100,1000);
Console.WriteLine("The random three-digit number is " + num);
Console.WriteLine(secondNum(num));

/*


task 13 

int cutThirdNumber (int num)
{
    if (num > 99)
    {
     while (num > 1000)
     {
        num = num / 10;
     }
     return num % 10;   
    }
    else
    {
        return -1;
    }
}

int num = new Random().Next(1,1000000);
Console.WriteLine("Random number is " + num);
int result = (cutThirdNumber(num));
if (result == -1)
{
    Console.WriteLine ("No third number");
}
else
{
    Console.WriteLine (cutThirdNumber(num));
}
*/

//task 15

/*
bool isDayOff (int num)
{
    if (num > 5)
    {
        return true;
    }
    else
    {
        return false;
    }
}

int num = new Random().Next(1,8);
Console.WriteLine("the number off the day is " + num);
Console.WriteLine(isDayOff(num));

/*