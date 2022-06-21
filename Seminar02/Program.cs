
// на вход двузначное число, определить наибольшую из них//
/*
int findMaxNumber(int num)
{
    int dec, ed;

    if (num >= 10 && num < 100)
    {
        dec = num / 10;
        ed = num % 10;

        if (dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
    }
    else
    {
        return -1;
    }
}

Console.Write("Input two-digit number: " );
int a = Convert.ToInt32(Console.ReadLine());

int result = findMaxNumber(a);
if (result == -1)
{
    Console.WriteLine("enter another number");
}
else
{
    Console.WriteLine($"the biggest number + {a} + is + {result}");
}


/* 
// с= a % b -  остаток от деления 5 % 2 = 1, 5 / 2 =2  
// 1234 / 10 -> 123 % 10 -> 3
// 1234 %10 -> 4
// 1234 % 100 -> 34
// 1234 / 100 -> 12



//Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.


/*
int saveFirstNumber(int num)
{
        int hun;
        hun = num / 100;
        return hun;
}
int saveThirdNmber(int num)
{
        int last;
        last = num % 10;
        return last;
}


Random rnd = new Random();
int num = rnd.Next(100,999);
Console.WriteLine(num);




int firstResult = saveFirstNumber(num);
int secondResult = saveThirdNmber(num);
Console.WriteLine($" new number + {num} + is + {firstResult}{secondResult}");
*/



/*
int cutNumber()
{
    int num = new Random().Next(100,1000);
    Console.WriteLine($"Current number is {num}");

    int hun = num / 100;
    int ed = hun % 10;

    int result = hun * 10 + ed;
    return result;
}

Console.WriteLine(cutNumber());


//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления.//
*/


string isMultipleNum(int num1, int num2)
{
int reminder;
reminder = num2 % num1;
    if (reminder == 0)
    {
        return "The number is multiple";
    }
    else
    {
        return (num2 % num1) + "The number is not multiple";
    }
}
Random rnd1 = new Random();
int num1 = rnd1.Next(100,999);
Console.WriteLine(num1);

Random rnd2 = new Random();
int num2 = rnd2.Next(100,999);
Console.WriteLine(num2);

Console.WriteLine(isMultipleNum(num1,num2)); 

/*Random rnd1 = new Random();
int num1 = rnd1.Next(100,999);
Console.WriteLine(num1);

Random rnd2 = new Random();
int num2 = rnd2.Next(100,999);
Console.WriteLine(num2);*/





bool isMultiped(int num)
{
    if (num % 23 *7 == 0) return true;
    else return false;
}
