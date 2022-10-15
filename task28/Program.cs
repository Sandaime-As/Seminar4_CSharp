/* **Задача 28:**

Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4 -> 24
5 -> 120 */

using static System.Console;
Clear();
Write("Enter the number: ");

int Mult = int.Parse(ReadLine()!);
int mult = GetSum(Mult);
WriteLine($"Произведение чисел: {mult}");

int GetSum(int number)
{
    int result=1;
    for(int i=1; i<=number; i++)
    {
        result*=i;
    }
    return result;
}