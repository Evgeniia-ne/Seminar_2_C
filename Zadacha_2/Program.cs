//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();
int DataЕntry(string str)
{
    Console.Write(str);
     int number = int.Parse(Console.ReadLine());
    return number;
}

void FindDiapazon(int kvadrant)
{
    if (kvadrant == 1) Console.WriteLine("(x>0) и (y>0)");
    if (kvadrant == 2) Console.WriteLine("(x<0) и (y>0)");
    if (kvadrant == 3) Console.WriteLine("(x<0) и (y<0)");
    if (kvadrant == 4) Console.WriteLine("(x>0) и (y<0)");
}

int kvadrant = DataЕntry("Введите номер квадранта: ");

FindDiapazon (kvadrant);
