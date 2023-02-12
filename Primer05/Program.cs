/*
## Primer05
Написать программу возведения числа А в целую стень B
*/
int M = new Random().Next(1,6); 
int N = new Random().Next(1,6); 
Console.WriteLine($"Число {M} в степени {N} = {stepen(M, N)}");

int stepen (int M, int N)
{
    if (N == 1) return M;
    if (N > 1) return M*stepen(M, N-1);
    return stepen(M, N);
}
