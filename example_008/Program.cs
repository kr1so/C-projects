Console.Clear();
//Console.SetCursorPosition(значение 1,значение 2);
//Console.WriteLine(+); - этим символом закрасим 

int xa = 10, ya = 15,
    xb = 20, yb = 10,
    xc = 30, yc = 15;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0;
while (count < 1000)
{
     int what = new Random().Next(0,3); // 0,1,2 - размер;
     if (what == 0)
{
    x=(x+xa)/2;
    x=(x+xa)/2;
} 
if (what == 1)
{
    x=(x+xb)/2;
    x=(y+yb)/2;
} 
if (what == 2)
{
    x=(x+xc)/2;
    x=(y+yc)/2;
} 
Console.SetCursorPosition(x,y);
Console.WriteLine("+");
count ++;
} 
