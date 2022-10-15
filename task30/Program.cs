/* Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0] */

using static System.Console;
Clear();
Write("Enter the size of array: ");
int size = int.Parse(ReadLine()!);
int[] array=GetBinaryArray(size);
PrintArray(array);

//int[] array1={1,0,1,0,1};   //первой метод заполнения массива
//int[] array2=new int[5];    //второй метод



int[] GetBinaryArray(int lenght)   //третий метод через рандом
{
    int[] result=new int[lenght];
    for(int i=0; i<lenght; i++)
    {
        result[i]=new Random().Next(0,2);
    }
    return result;
}

void PrintArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length-1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length-1]}]");
}