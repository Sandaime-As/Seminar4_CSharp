/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

7 -> 28

4 -> 10

8 -> 36*/

using static System.Console;
Clear();
Write("Enter the number A: ");

int A=int.Parse(ReadLine()!);
int sum=GetSum(A);
WriteLine($"Сумма чисел от 1 до А равна: {sum}");
//WriteLine($"Сумма чисел от 1 до А равна: {GetSum1(A)}");

int GetSum(int number)
{
    int result=0;
    while(number>0)         // через while
    {
        result+=number;
        number--;
    }
    return result;
}


// int GetSum1(int number)
// {
//     int result=0;
//     for(int i=1;i<=number;i++) //через метод "for"
//     {
//         result+=i;
//     }
//     return result;
// }