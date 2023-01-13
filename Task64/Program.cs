// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message)
{
    System.Console.Write(message);
    int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}
int N =Prompt("Введите число > ");

void FindN(int N)
{
    if(N==0) return;
    System.Console.Write(N);
    FindN(N-1);
    
}
FindN(N);