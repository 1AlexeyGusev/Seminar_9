// Задача 63: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке
//  от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNaturals(int N)
{
    Console.Write($"{N} -> ");
    for (int i = 1; i <= N; i++)
    {
        Console.Write($"{i}, ");
    }
}
PrintNaturals(N);
Console.WriteLine();

//Рекурсия---------------------------------------------------------------------------

string PrintNumber(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + PrintNumber(start + 1, end));
}
Console.Write($"{N} -> ");
Console.Write(PrintNumber(1, N));
