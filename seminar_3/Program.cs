// Напишите программу, которая на вход принимает координаты точек (x, y),
// причем x != 0 и y != 0 и выдает номер четверти, в котором находится эта точка

// void SearchSquad(int x, int y)
// {
//     if(x == 0 || y == 0)
//     {
//         Console.WriteLine("Error");
//     }    
//     else if(x > 0 && y > 0)
//     {
//         Console.WriteLine("Точка находится в первой четверти");
//     }
//     else if(x > 0 && y < 0)
//     {
//         Console.WriteLine("Точка находится в четвертой четверти");
//     }
//     else if(x < 0 && y > 0)
//     {
//         Console.WriteLine("Точка находится в второй четверти");
//     }
//     else 
//     {
//         Console.WriteLine("Точка находится в третьей четверти");
//     }
// }
// Console.Write("Введите координату х: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// SearchSquad(x, y);





// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите четверть: ");
// int quarter = Convert.ToInt32(Console.ReadLine());


// void SearchQuarter(int quarter)
// {
//     if(quarter == 1)
//     {
//         Console.WriteLine("х > 0 and y > 0");
//     }
//     else if(quarter == 2)
//     {
//         Console.WriteLine("x < 0 and y > 0");
//     }
//     else if(quarter == 3)
//     {
//         Console.WriteLine("x < 0 and y > 0");
//     }
//     else if(quarter == 4)
//     {
//         Console.WriteLine("x > 0 and y < 0");
//     }
//     else
//     {
//         Console.WriteLine("Error");
//     }

// }
// SearchQuarter(quarter);



// Напишите программу, 
// которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

// Console.Write("Enter your number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void Kvadrat(int number)
// {
//     for(int count = 1; count <= number; count ++)
//     {
//         Console.Write(count * count + " ");
//     }
// }
// Kvadrat(number);


// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.Write("Enter your a number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter your a1 number: ");
// int a2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter your b number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter your b1 number: ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// double DvaD(int a, int a2, int b, int b2)
// {
//     double f = (a - a2) * (a - a2) + (b - b2) * (b - b2);
//     double g = Math.Sqrt(f);
//     return g;
// }
// double res = DvaD(a, a2, b, b2);
// Console.WriteLine($"res = {Math.Round(res, 2)}");