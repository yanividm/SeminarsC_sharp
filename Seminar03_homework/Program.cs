


// Task19 Напишите программу, которая принимает на вход пятизначное число 
//и проверяет, является ли оно палиндромом.
/*
string Polydrome(int num)
{
    if (num / 10000 == num % 10)
    {
        int secondNum = num / 1000;
        secondNum = secondNum % 10;

        int forthNum = num % 100;
        forthNum = forthNum / 10;

        if (secondNum == forthNum)
        {
            return ($"{num} is polydrome");
        }
        else
        {
            return  ($"{num} is not polydrome");
        }
    }
    else
    {
        return ($"{num} is not polydrome");
    }

}

int num;
Console.WriteLine(" Input first integer number ");
num = Convert.ToInt32(Console.ReadLine());
if (num >= 10000 && num <100000)
{
    Console.WriteLine(Polydrome(num));
}
else
{
    Console.WriteLine("Please enter 5 digit number");
}

*/

//task 21 Напишите программу, 
//которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

/*
double findLenght(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double coard = Math.Pow((x2 - x1),2)  + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2);
    double coardEnd =  Math.Sqrt(coard);
    return (coardEnd);
}

int x1;
Console.WriteLine(" Input first x-axis cord number ");
x1 = Convert.ToInt32(Console.ReadLine());
int y1;
Console.WriteLine(" Input first y-axis cord number ");
y1 = Convert.ToInt32(Console.ReadLine());
int z1;
Console.WriteLine(" Input first z-axis cord number ");
z1 = Convert.ToInt32(Console.ReadLine());
int x2;
Console.WriteLine(" Input second x-axis cord number ");
x2 = Convert.ToInt32(Console.ReadLine());
int y2;
Console.WriteLine(" Input second  y-axis cord number ");
y2= Convert.ToInt32(Console.ReadLine());
int z2;
Console.WriteLine(" Input second z-axis cord number ");
z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(findLenght(x1,y1, z1,x2, y2,z2));
*/

//Task 23

//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
/*
void findCube(int num)
{
    int count = 1;
    while (count <= num)
    {
        Console.Write((count * count* count) + " ");
        count++;
    }
}

int num;
Console.WriteLine(" Input natural number ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 0)
{
    findCube(num);
}
else
{
    Console.WriteLine("Error, please, input another natural number ");
}

/*