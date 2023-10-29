// Задача 69: Напишите программу, которая на вход 
// принимает два числа A и B, и возводит число А в 
// целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int Pow(int A, int B)
{
    if (B == 0) return 1;
    else if (B == 1) return A;
    else return A * Pow(A, B - 1);
}

Pow(A, B);
Console.Write(Pow(A, B));