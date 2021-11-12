Console.Clear();
System.Console.WriteLine("Задача про двух друзей и собаку");
System.Console.WriteLine(" Есть два друга, которые движутся с разной скоростью."
            + " У них есть собака, которая бегает периодически от одного друга к другому."
            + " Пока собака бежит ко второму другу, один тоже движется."
            + " Пока два друга идут друг до друга, "
            + " через сколько раз перебеганий собаки они встретятся?");
int count = 0, distance = 10000, firstFriendSpeed = 1, secondFriendSpeed = 2, dogSpeed = 5, time = 0,  friend = 2;
while (distance > 10)
{
    for (time = 0; friend == 1; count++)
    {
         time = distance / (firstFriendSpeed + dogSpeed);
         friend = 2;
    }
         for (time = 0; friend == 2; count++)
         {
            time = distance / (secondFriendSpeed + dogSpeed);
            friend = 1;
         }
     distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
}
string result = $" Получилось {count} раз";
System.Console.WriteLine(result);
/* while (distance > 10)
{
     if (friend == 1)
     {
         time = distance / (firstFriendSpeed + dogSpeed);
         friend = 2;
         count++;
     }
     if (friend == 2)
     {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
        count++;
     } 
     distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
}
string result = $" Получилось {count} раз";
System.Console.WriteLine(result); */
