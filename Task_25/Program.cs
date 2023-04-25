/* Задача 25:
   Напишите цикл, который принимает на вход 
   два числа (A и B) и возводит число A в натуральную степень B.

   3, 5 -> 243 (3⁵)
   2, 4 -> 16
*/


Console.Clear();

Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);

int GetDegree(int n)
{
    int result = 1;
    for (int i = 1; i <= B; i++)
        result *= A;
    return result;
}

Console.WriteLine($"{A}, {B} -> {GetDegree(B)}");