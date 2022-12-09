// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Please, enter your number a: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please, enter your number b: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int St(int a, int b)
// {
//     int st = 1;
//     for(int i = 1; i <= b; i++)
//     {
//         st = st * a;
//     }
//     return st;
// }
// int res = St(a, b);
// Console.WriteLine(res);










// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// (Массивы и строки использовать нельзя!!!)
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.Write("Please, enter your number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int SummNumbers(int number)
// {
//     if(number == 0)
//     {
//         return 0;
//     }
//     else {
//     int res1 = number % 10;
//     int res2 = number % 100 / 10;
//     int res3 = number % 1000 / 100;
//     int res4 = number % 10000 / 1000;
//     int res5 = number % 100000 / 10000;
//     int res6 = number % 1000000 / 100000;
//     int result = res1 + res2 + res3 +res4 + res5 + res6;
//     return result;
//     }
// }
// int res11 = SummNumbers(number);
// Console.WriteLine(res11);              //не понял как сделать через цикл((











// Задача 29: Напишите программу, которая задаёт массив из 
// произвольного кол-ва элементови выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Console.Write("Please enter the length of the array ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] Array(int number)
// {
//     int [] arr = new int [number];
//     for (int i = 0; i < number; i++)
//     {
//         arr[i] = new Random().Next(5,16);
//     }

//     return arr;
// }
// void ShowArray (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
// }

// ShowArray(Array(number));



