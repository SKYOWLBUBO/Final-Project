// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    System.Console.Write(message);
    int lenght = Convert.ToInt32(Console.ReadLine());
    return lenght;
}
int m = Prompt("Введите первое число > ");
int n = Prompt("Введите второе число > ");

System.Console.WriteLine(LeviAckerman(m, n));

int LeviAckerman(int m, int n)
{
    if (m == 0) 
    {
      return n + 1;
    }
    else if (n == 0) 
    {
      return LeviAckerman(m - 1, 1);
    }
    else 
    {
      return LeviAckerman(m - 1, LeviAckerman(m, n - 1));
    }
}