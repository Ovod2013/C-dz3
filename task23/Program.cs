/*Задача 23
Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125    */
int x;
Console.Write("Введите положительное целое число больше 0: ");
x=int.Parse(Console.ReadLine()!);

double Cub(int vx)// определение метода вычисления куба
{
double cub = vx*vx*vx;
 return cub;
}

if (x<1) Console.Write ("Число не соответствует условию");// Проверка числа на соответствие условию
else if (x>=1) Console.Write ("1");
if (x>=2)
{
int i;
for(i=2; i <= x; i++)
{
Console.Write (", " + Cub(i));
}
}