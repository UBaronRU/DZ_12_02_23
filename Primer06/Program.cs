/*
## Primer06
Написать программу показывающие первые N чисел, 
для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем
*/
Console.Write("Введите первое число последовательности: ");
int Num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число последовательности: ");
int Num2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество чисел: ");
int Num3 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Числа: ");
Console.WriteLine($"{Num1}\t");
Console.WriteLine($"{Num2}\t");
for (int i = 2; i < Num3; i++)
{
    int temp = Num1;
    Num1=Num2;
    Num2=Num1+temp;
    Console.WriteLine($"{Num2}\t");
}