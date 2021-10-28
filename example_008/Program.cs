Console.Clear();
//Console.SetCursorPosition(значение 1,значение 2);
//Console.WriteLine(+); - этим символом закрасим 

int xa = 40, ya = 1, //ввод переменных и значений для них
    xb = 1,  yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya); //обозначение курсора
Console.WriteLine("+");            // вывод на консоль положения курсора. и так с каждой переменной

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = ya; //ввод новой переменной

int count = 0;      //ввод count - количество повторений

while (count < 10000) //цикл while (пока count < 10000)
{
     int what = new Random().Next(0,3); // 0,1,2 - размер;

if (what == 0)       // цикл if - если переменная what (рандомное число в массиве от 0 до 3) = , то выполнять след. д-ие:
    {
    x=(x + xa)/2; // тело цикла
    y=(y + ya)/2;  // тело цикла
    } 

if (what == 1)
    {
    x=(x + xb)/2;
    y=(y + yb)/2;
    } 

if (what == 2)
    {
    x=(x + xc)/2;
    y=(y + yc)/2;
    } 

  Console.SetCursorPosition(x,y); // позиция на консоли переменных
  Console.WriteLine("+"); // обозначение и рисунок
  count = count+1; // увеличение на 1 для движения цикла. цикл while остановится, когда count = 10000
} 