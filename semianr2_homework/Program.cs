//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine("Enter your number: ");
// int numb =Convert.ToInt32(Console.ReadLine());
// int Numb(int numb)
// {
//     if(numb > 100)
//     {
//         int des = numb / 10 % 10;
//         return des;
//     }
//     else
//     {
//         return -1;
//     }
// }
// Console.WriteLine(Numb(numb));




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 63279 -> 2


// Console.WriteLine("Enter your number: ");
// int numb1 =Convert.ToInt32(Console.ReadLine());
// void Numb3(int numb1)
// {
//     if((numb1 > 99)&&(numb1 < 1000))
//     {
//         int ed = numb1 % 10;
//         Console.WriteLine(ed);
//     }
//     if((numb1 > 999)&&(numb1 < 10000))
//     {
//         int des = numb1 /10 % 10;
//         Console.WriteLine(des);
//     }
//     if((numb1 > 9999)&&(numb1 < 100000))
//     {
//         int sot = numb1 / 100 % 10;
//         Console.WriteLine(sot);
//     }
//     if((numb1 > 999999)&&(numb1 < 10000000))
//     {
//         int tis = numb1 / 100 / 100 % 10;
//         Console.WriteLine(tis);
//     }
//     else
//     {
//         Console.WriteLine("There is no third digit");
//     }
// }
// Numb3(numb1);                //К сожалению не понял как решать по другому((




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Console.WriteLine("Enter your number: ");
// int numb2 =Convert.ToInt32(Console.ReadLine());

// void Numb4(int numb2)
// {
//     if(numb2 == 6)
//     {
//         Console.WriteLine("Yes");
//     }
//     if(numb2 == 7)
//     {
//         Console.WriteLine("Yes");
//     }
//     if(numb2 < 6)
//     {
//         Console.WriteLine("No");
//     }
// }
// Numb4(numb2);