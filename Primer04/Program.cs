/*
## Primer04
Написать программу вычисления функции Аккермана
*/

int M = new Random().Next(1,4); 
int N = new Random().Next(1,4); 
Console.WriteLine($"Функция Аккермана для чисел {M} и {N} = {AckermannF(M, N)}");

int AckermannF (int M, int N)
{
    if (M == 0) return N + 1;
    if (M != 0 && N == 0) return AckermannF(M - 1, 1);
    if (M > 0 && N > 0) return AckermannF(M - 1, AckermannF(M, N - 1));
return AckermannF(M, N);
}
