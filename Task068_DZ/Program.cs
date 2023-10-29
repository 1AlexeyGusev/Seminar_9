// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m:");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n:");
int n = int.Parse(Console.ReadLine());

int AccermanFunc(int m, int n)
{
    if (m < 0 || n < 0) return 0;
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return AccermanFunc(m - 1, 1);
    return AccermanFunc(m - 1, AccermanFunc(m, n - 1));
}
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {AccermanFunc(m, n)}");

//Смысл формулы Аккермана я не понял, гугл помог с решением)