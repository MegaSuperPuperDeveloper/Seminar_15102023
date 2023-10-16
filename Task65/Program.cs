// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void CountMtoN(int M, int N) { // Функция выводит все числа от M до N.
    if(M == N) {
        Console.Write(M);
        return;
    } else {
        Console.Write($"{M}, ");
    }
    CountMtoN(M + 1, N); 
}

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
if(num < 1 || num1 < 1) {
    Console.WriteLine("Ошибка ввода!");
    return;
}
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write($"M = {num1}; N = {num} -> " + '"');
CountMtoN(num, num1);
Console.Write('"');
