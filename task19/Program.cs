/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125    */

Console.Write("Введите число: ");
int x=int.Parse(Console.ReadLine()!);

double Cub(int vx)// определение метода вычисления куба
{
double cub = vx*vx*vx;
 return cub;
}

int i;// цикл вычисления и вывода куба
for(i=1; i <= x; i++)
{
Console.Write (" " + Cub(i));
}
