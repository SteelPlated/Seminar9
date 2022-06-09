/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());
/*
void GetNumPow(int n, int m, int comp)
{
    if (m == 0)
    {
        Console.WriteLine(comp);
        return;
    }
    comp *= n;
    GetNumPow(n, m - 1, comp);
}
*/
Console.WriteLine($"\n{a} в степени {b} равно: {Pow(a, b)}\n");
int Pow(int a, int pow)
{
    return pow == 0 ? 1 : Pow(a, pow - 1) * a;
}

