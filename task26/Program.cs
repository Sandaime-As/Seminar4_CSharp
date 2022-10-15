/* **Задача 26:**

Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

456 -> 3

78 -> 2

89126 -> 5 */

using static System.Console;
Clear();
Write("Enter the number: ");

int Sum = int.Parse(ReadLine()!);
int sum = GetSum(Sum);
WriteLine($"Количество цифр в числе: {sum}");

int GetSum(int number)
{
    int result=0;
    while(number>0)         // через while
    {
        number/=10;
        result++;
    }
    return result;
}