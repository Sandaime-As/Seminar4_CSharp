/* Напишите программу, которая посчитает количество нулей
 в массиве заполненный нулями и единицами в случайном порядке.

[1,0,1,1,0,1,0,0] 
количество 0: 4 */

using static System.Console;
Clear();
Write("Enter the size of array: ");
int size = int.Parse(ReadLine()!);
int[] array=GetBinaryArray(size);
PrintArray(array);
WriteLine();
WriteLine($"количество нулей в массиве = {count(array)}");


int[] GetBinaryArray(int lenght)   
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

int count(int[] inArray)
{
    int result=0;
    for(int i=0; i<inArray.Length-1; i++)
    {
        if(inArray[i]==0)
        {
            result+=1;
        }
    }
    return result;
}