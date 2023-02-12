/*
## Primer01
Показать натуральные числа от 1 до N, N задано
Показать натуральные числа от N до 1, N задано
Показать натуральные числа от M до N, N и M заданы
*/
int N = new Random().Next(1,100); 
int M = new Random().Next(1,100); 
Console.WriteLine();
// Показать натуральные числа от 1 до N, N задано
Console.Write($"Выводим ряд от 1 до {N}"); 
Console.WriteLine();
for (int i = 1; i <= N; i++)
{
   Console.Write($"{i}\t"); 
}
// Показать натуральные числа от N до 1, N задано
Console.WriteLine();
Console.WriteLine();
Console.Write($"Выводим ряд от {N} до 1"); 
Console.WriteLine();
for (int i = N; i >= 1; i--)
{
   Console.Write($"{i}\t"); 
}
//Показать натуральные числа от M до N, N и M заданы
Console.WriteLine();
Console.WriteLine();
Console.Write($"Выводим ряд от {M} до {N}\t"); 
Console.WriteLine();
if (M > N)
{
   for (int i = M; i >= N; i--)
{
   Console.Write($"{i}\t"); 
}     
}
else
{
   for (int i = M; i <= N; i++)
{
   Console.Write($"{i}\t"); 
} 
}
