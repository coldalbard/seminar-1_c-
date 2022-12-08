// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Please, enter your number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// void Palindrome(int number)
// {
//     if(number > 9999 && number < 99999)
//     {
//         int res3 = number % 10;
//         int res1 = number / 10000;
//         int res2 = number / 1000 % 10;
//         int res4 = number % 100 / 10;
//         if(res1 == res3 && res2 == res4)
//         {
//             Console.WriteLine("Yes");
//         }
//         else if(res1 != res2)
//         {
//             Console.WriteLine("No");
//         }
//     }
//     else if(number < 9999 || number > 99999)
//     {
//         Console.WriteLine("Error");
//     }
// }
// Palindrome(number);






// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Please, enter your a1 number: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please, enter your b1 number: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please, enter your a2 number: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please, enter your b2 number: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please, enter your a3 number: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please, enter your b3 number: ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// // (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2

// double DvaD(int x1, int x2, int y1, int y2, int z1, int z2)
// {
//     double f = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1);
//     double g = Math.Sqrt(f);
//     return g;
// }
// double res = DvaD(x1, x2, y1, y2, z1, z2);
// Console.WriteLine($"res = {Math.Round(res, 2)}");







// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.WriteLine("Please, enter your number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// void Kub(int number1)
// {
// for(int i = 1; i <= number1; i++)
// {
//     Console.Write(i * i * i + ";  ");
// }
// }
// Kub(number1);