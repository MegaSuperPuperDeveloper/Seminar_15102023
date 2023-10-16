// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Pow(int A, int B, int res, int count = 0) { // Функция возводит число в степень.
    if(count == B - 1) return res;
    res *= A;
    count++;
    return Pow(A, B, res, count);
}

Console.Write("Число которое будет возведенно в степень: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Степень этого числа: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write($"A = {A}; B = {B} -> {Pow(A, B, A)}");