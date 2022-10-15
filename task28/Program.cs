/* **Задача 28:**

Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4 -> 24
5 -> 120 */

using static System.Console;
Clear();
Write("Enter the number: ");

int Sum = int.Parse(ReadLine()!);
int sum = GetSum(Sum);
WriteLine($"Произведение чисел: {sum}");

int GetSum(int number)
{
    int result=1;
    for(int i=1; i<=number; i++)
    {
        result*=i;
    }
    return result;
}