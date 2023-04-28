// Напишите программу, которая принимает на вход 
//координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату X1 первой точки: ");
int xa=int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y1 первой точки: ");
int ya=int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z1 первой точки: ");
int za=int.Parse(Console.ReadLine()!);


Console.Write("Введите координату X2 второй точки: ");
int xb=int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Y2 второй точки: ");
int yb=int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Z2 второй точки: ");
int zb=int.Parse(Console.ReadLine()!);


//Rasst(xa, ya, xb, yb);

double Rasst(int xxa, int yya, int zza, int xxb, int yyb, int zzb)
{
double ab = Math.Round(Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya) + (zb - za)*(zb - za)),2);
 return ab;
}

//double ab = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya));

Console.WriteLine ("Расстояние между точками: " + Rasst(xa, ya, za, xb, yb, zb));
