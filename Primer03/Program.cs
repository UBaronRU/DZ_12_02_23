/*
## Primer03
Найти сумму цифр числа
*/

int Num1; // Основное число
int Num3; // Основное число
int Num2; // Основное число
int Num_rzd; // Разрядность основного числа
int Sum_rzd=0;
Num_rzd = 1;
string [] array = {"разрядов","разряд","разряда","разряда","разряда","разрядов","разрядов","разрядов","разрядов","разрядов",};
string okonchanie= "";
int temp_dig ;
Num1 = new Random().Next(10,999999999); 
// Определяем разрядность числа
while (Num1 / Math.Pow(10,Num_rzd) > 1 & Num_rzd < 10)
{
Num_rzd = Num_rzd + 1; 
}
okonchanie = array [Num_rzd%10];
Console.WriteLine(" У введенного числа "+Num1+" -> " + Num_rzd + " "+okonchanie);
Num3=Num1;
for (int i = Num_rzd; i > 0; i--)
{
    temp_dig = 1;
    for (int ii = 1; ii < i; ii++)
    {
        temp_dig=temp_dig*10;
    }
    Num2 = Num3 / temp_dig;
    Sum_rzd = Sum_rzd + Num2;
    Num3 = Num3 - (Num2 * temp_dig);
}
    Console.WriteLine("Сумма разрядов веденного числа "+Num1+" = " + Sum_rzd);
