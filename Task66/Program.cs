// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int Prompt(string message)
{
    System.Console.Write(message);
    int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}
int M = Prompt("Введите первое число > ");
int N = Prompt("Введите второе число > ");
int sum = 0;
for (int i = M; i <= N; i++)
{
    sum = sum + i;
}
System.Console.WriteLine(sum);
