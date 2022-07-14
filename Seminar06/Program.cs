// программа на разворот массива

/*
 int [] Reversarray(int [] array)
 {
    int temp;
    int j = array.Length - 1;

    for (int i = 0; i < array.Length / 2 ; i++, j --)
    {
        temp = array [i];
        array [i] = array [j];
        array [j] = temp;
    }
    return array;
 }

int [] myArray = {2,3,6,1,2};
myArray = Reversarray (myArray);

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
*/
// принимает три стороны и проверяет существование такого треугольника ( две стороны в сумме больше третьей)
/*
bool triangleExist(int a, int b, int c)
{
    if (a+b > c )
    {
        if (b+c > a)
        {
            Console.WriteLine("triangle exist");
            return true;
        }
        else
        {
            Console.WriteLine("triangle doesnt exist");
            return false;
        }
    }
    else
    {
        Console.WriteLine("triangle doesnt exist");
    } 
    return false;
}

int a = 13;
int b = 24;
int c = 13;
Console.WriteLine(triangleExist(a,b,c));
*/

// нерекурсионный вариант возврата чисел фибоначе 
/*
void reversFibonachi(int n)
{
    int [] array = new int [n];
    array [0] = 0;
    array [1] = 1;
    Console.Write(array[0] + " " + array[1] + " ");
    for (int i = 2; i < n; i++)
    {
        array [i] = array [i - 1] + array [i-2];
        Console.Write(array[i] + " ");
    }
}
int n = 7;
reversFibonachi(n);

*/

// метод, преобразует 10 ричное в двоичное (инт в стринг в обратном порядке)

string createDoubleNum(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}

Console.WriteLine(createDoubleNum(13));