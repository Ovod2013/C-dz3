/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите пятизначное десятичное число: ");
int x=int.Parse(Console.ReadLine()!);

if (x<10000 || x>99999) Console.Write("Это не пятизначное число!");
else{
int c5=x%10; 
//Console.WriteLine (c5);
int c4=(x/10)%10; 
//Console.WriteLine (c4);
int c3=(x/100)%10; 
//Console.WriteLine (c3);
int c2=(x/1000)%10; 
//Console.WriteLine (c2);
int c1=(x/10000)%10; 
//Console.WriteLine (c1);


if (c5==c1 && c4==c2) Console.WriteLine ("Да, это палиндром");
else Console.WriteLine ("Нет, это не палиндром");
}