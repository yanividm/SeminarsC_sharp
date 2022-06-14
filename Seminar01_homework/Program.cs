/* Task 2

int num1, num2;

Console.WriteLine(" Input first integer number ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Input second integer number ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("max= " + num1);
}
else
{
    Console.WriteLine("max= " + num2);
} */

/* Task4

int num1, num2, num3;

Console.WriteLine(" Input first integer number ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Input second integer number ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(" Input third integer number ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.WriteLine("max number is " + num1);
    } 
    else
    {
        if (num2 > num3)
    {
        Console.WriteLine("max number is " + num2);
    }
    else
    {
        Console.WriteLine("max number is " + num3);
    }
    }
}
else
{
    if (num2 > num3)
    {
        Console.WriteLine("max number is " + num2);
    }
    else
    {
        Console.WriteLine("max number is " + num3);
    }
} */


/* Task 6

int num;

Console.Write("Input integer number ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 ==0)
{
    Console.WriteLine(num + " четное число");
}
else
{
    Console.WriteLine(num + " нечетное число");
}
*/


/* Task 8

int num;

Console.Write(" Input integer number ");
num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= num)
    {
        if (current % 2 ==0)
        {
            Console.Write(current + " ");
            current = current + 2;
        }
        else
        {
            current = current + 1;
            Console.Write(current + " ");
        }
    }
 
 */
