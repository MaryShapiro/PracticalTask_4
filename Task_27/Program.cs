/* Задача 27: 
   Напишите программу, которая 
   принимает на вход число и выдаёт сумму цифр в числе.

   452 -> 11
   82 -> 10
   9012 -> 12
*/


Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

int GetSum(int n)
{
    int sum = 0;
    int i = 1;
    if (n < 0)
    {
        n *= (-1);
    }
    for (; i > 0; i++)
    {
        sum += n % 10;
        n = n / 10;
    }
    return sum;
}

Console.WriteLine($"{num} -> {GetSum(num)}");
