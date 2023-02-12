/*
## Primer02
Найти сумму элементов от M до N, N и M заданы
*/
int N = new Random().Next(1,10); 
int M = new Random().Next(1,10); 
int summElements =0;
Console.WriteLine();
Console.Write($"Находим сумму элементов от {M} до {N}"); 
Console.WriteLine();
if (M > N)
{
   for (int i = M; i >= N; i--)
    {   
    summElements=summElements+i;
    }     
}
else
{
   for (int i = M; i <= N; i++)
{
    summElements=summElements+i;
} 
}
Console.Write($" Сумма элементов от {M} до {N} равнв {summElements}"); 
