﻿/* int num;

Console.Write("input integer number ");
num = Convert.ToInt32(Console.ReadLine());

num = num * num;

Console.WriteLine("Result is " + num);
*/

/* int num1, num2, quad;

Console.Write("input first integer number ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("input second integer number ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if (num1 == quad)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
*/

int num;

Console.Write(" Input integer number: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while (current <= num)
{
    Console.Write(current + " ");
    current++; // current + 1
}