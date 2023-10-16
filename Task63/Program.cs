// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

void CountOneToN(int N, int count = 1) { // Функция выводит числа от 1 до N
    if(count == N) {
        Console.Write(count);
        return;
    } else {
        Console.Write($"{count}, ");
    }
    CountOneToN(N, count + 1); 
}

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {num} -> " + '"');
CountOneToN(num);
Console.Write('"');