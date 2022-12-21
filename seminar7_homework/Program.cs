// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] FillArray(int m, int n)
// {
//     double[,] array = new double [m, n];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().NextDouble() * new Random().Next(-100, 100);
//             array[i, j] = Math.Round(array[i , j], 2);
//         }
//     }
//     return array;
// }
// // Функция для создания двумерного массива с вещественными элементами



// void ReturnArray(double[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// // Функция для вывода массива на экран



// Console.Write("Please enter the number of rows in your array: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int n = Convert.ToInt32(Console.ReadLine());


// double[,] arr = FillArray(m, n);
// // присваиваем переменной arr массив из функции FillArray

// ReturnArray(arr);







// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет



// int[,] CreateArray(int x, int y)
// {
//     int[,] array = new int [x, y];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }
// // Функция для создания двумерного массива




// void PrintArray(int[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// // Функция для вывода массива на экран



// void UserNumber(int[,] new_arr)
// {
//     Console.Write("Please, enter the line index: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Please, enter the column index: ");
//     int columns = Convert.ToInt32(Console.ReadLine());
//     if(rows < 0
//     || rows > new_arr.GetLength(0) - 1 
//     || columns < 0
//     || columns > new_arr.GetLength(1) - 1)
//     {
//         Console.Write("There is no such number in the array");
//     }
//     else
//     {
//         Console.Write($"The element under these indexes = {new_arr[rows, columns]};");
//     }
// }
// // Функция для нахождения элемента по индексу




// Console.Write("Please enter the number of rows in your array: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] new_arr = CreateArray(x, y);
// // присваиваем переменной arr массив из  функции CreateArray

// PrintArray(new_arr);

// UserNumber(new_arr);









// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


// int[,] CreateArray(int x, int y)
// {
//     int[,] array = new int [x, y];
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return array;
// }
// // Функция для создания двумерного массива




// void PrintArray(int[,] arr)
// {
//     for(int i = 0; i < arr.GetLength(0); i++)
//     {
//         for(int j = 0; j < arr.GetLength(1); j++)
//         {
//             Console.Write($"{arr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// // Функция для вывода массива на экран




// void ArithmeticMean(int[,] new_arr)
// {
//     for(int i = 0; i < new_arr.GetLength(0); i++)
//     {
//         int[] res = new int [new_arr.GetLength(1)];
//         for(int j = 0; j < new_arr.GetLength(1); j++)
//         {
//             res[i] += new_arr[j, i];
//         }
//         Console.Write($"{res[i] / new_arr.GetLength(1)}; ");
//     }
// }
// // Функция для вычисления среднего арифметического
// // Скажу честно, я нашел вариант решения в инете, но если я так делаю я разбираюсь
// // как и почему это работает. Но здесь мои полномочия все), в принципе я понял
// // как работает new_arr[j, i], но не понял почему у нас не меняется итерация строк
// // пока у нас не закончится итерация таблицы 
// // (если бы вы мне обьяснили было бы неплохо)



// Console.Write("Please enter the number of rows in your array: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Please enter the number of columns in your array: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int[,] new_arr = CreateArray(x, y);
// // присваиваем переменной arr массив из  функции CreateArray

// PrintArray(new_arr);

// ArithmeticMean(new_arr);