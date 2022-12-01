Console.Clear();
int DataЕntryXY(string str)
{
    Console.Write(str);
     int number = int.Parse(Console.ReadLine());
    return number;
}

void FindKvandrat(int x, int y)
{
    if ((x>0) && (y>0)) Console.WriteLine("Это первый квадрант");
    if ((x<0) && (y>0)) Console.WriteLine("Это второй квадрант");
    if ((x<0) && (y<0)) Console.WriteLine("Это четвертый квадрант");
    if ((x>0) && (y<0)) Console.WriteLine("Это третий квадрант");
}

int x = DataЕntryXY("Введите координаты x: ");
//Console.WriteLine(x);
int y = DataЕntryXY("Введите координаты y: ");
//Console.WriteLine(y);
FindKvandrat (x,y);
