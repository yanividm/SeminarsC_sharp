//task 25 

/*
double exponentingNum(int num1, int num2)
{
    return Math.Pow((num1),num2);
}

int num1;
Console.WriteLine("Enter first integer number");
num1 = Convert.ToInt32(Console.ReadLine());

int num2;
Console.WriteLine("Enter second integer number");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(exponentingNum(num1,num2)); */

/*
void exponentingNum()
{
    int num1;
    Console.WriteLine("Enter first integer number");
    num1 = Convert.ToInt32(Console.ReadLine());

    int num2;
    Console.WriteLine("Enter second integer number");
    num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Math.Pow((num1),num2));

}

exponentingNum();

*/

//task 29

/* 
void createArray()
{
    int length;
    Console.WriteLine("Enter an amount of array");
    length = Convert.ToInt32(Console.ReadLine());
    
    int [] array = new int [length]; 
    int index = 0;

    while (index < length)
    {
        array [index] = new Random().Next(1,1000);
        Console.Write(array [index] + " ");
        index++;
    }
}



/*

void createArray()
{
    int size;
    Console.WriteLine("Enter an amount of array");
    size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [size];

    for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next();
}
        for (int i = 0; i < size; i++)
            {
                Console.Write(array[i]+ " ");
            }
}

createArray();
*/ 

/*
int createArray()
{
    int size;
    Console.WriteLine("Enter an amount of array");
    size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int [size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,1000);
        Console.Write(array[i]+ " ");
    }
    return array[size];
    
}
createArray(); */