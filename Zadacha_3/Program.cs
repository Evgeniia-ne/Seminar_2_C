//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Clear();
int DataЕntry(string str)
{
    Console.Write(str);
     int number = int.Parse(Console.ReadLine());
    return number;
}

double FindDist(int x1,int y1,int x2,int y2)
{   
   double result = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
   return result;
}

int x1 = DataЕntry("Введите координаты x1: ");
int y1 = DataЕntry("Введите координаты y1: ");

int x2 = DataЕntry("Введите координаты x2: ");
int y2 = DataЕntry("Введите координаты y2: ");

double result = FindDist (x1,y1,x2,y2);
Console.WriteLine(result);