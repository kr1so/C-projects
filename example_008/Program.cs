Console.Clear();
//Console.SetCursorPosition(значение 1,значение 2);
//Console.WriteLine(+); - этим символом закрасим 

int xa = 1, ya = 1,
    xb = 1,  yb = 15,
    xc = 60, yc = 15;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;

int count = 0;

while (count < 10000)
{
     int what = new Random().Next(0,3); // 0,1,2 - размер;
     if (what == 0)
    {
    x=(x + xa)/2;
    x=(x + xa)/2;
    } 

if (what == 1)
    {
    x=(x + xb)/2;
    x=(y + yb)/2;
    } 

if (what == 2)
    {
    x=(x + xc)/2;
    x=(y + yc)/2;
    } 

  Console.SetCursorPosition(x,y);
  Console.WriteLine("+");
  count = count+1;
} 